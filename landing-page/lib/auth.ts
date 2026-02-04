import { NextAuthOptions } from 'next-auth';
import CredentialsProvider from 'next-auth/providers/credentials';
import bcrypt from 'bcrypt';
import { prisma } from './prisma';

export const authOptions: NextAuthOptions = {
  providers: [
    CredentialsProvider({
      name: 'Credentials',
      credentials: {
        email: { label: 'Email', type: 'email' },
        password: { label: 'Password', type: 'password' },
      },
      async authorize(credentials) {
        if (!credentials?.email || !credentials?.password) {
          return null;
        }

        const partner = await prisma.partner.findUnique({
          where: { email: credentials.email },
        });

        if (!partner) {
          return null;
        }

        // Check if partner is active
        if (partner.status !== 'ACTIVE') {
          throw new Error('Account pending approval or suspended');
        }

        const isPasswordValid = await bcrypt.compare(
          credentials.password,
          partner.passwordHash
        );

        if (!isPasswordValid) {
          return null;
        }

        return {
          id: partner.id,
          email: partner.email,
          name: `${partner.firstName} ${partner.lastName}`,
        };
      },
    }),
  ],
  session: {
    strategy: 'jwt',
  },
  pages: {
    signIn: '/partners/login',
    error: '/partners/login',
  },
  callbacks: {
    async jwt({ token, user }) {
      if (user) {
        token.id = user.id;
      }
      return token;
    },
    async session({ session, token }) {
      if (session.user) {
        session.user.id = token.id as string;
      }
      return session;
    },
  },
  secret: process.env.NEXTAUTH_SECRET,
};
