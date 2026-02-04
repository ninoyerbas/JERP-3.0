import { NextResponse } from 'next/server';
import bcrypt from 'bcrypt';
import { z } from 'zod';
import { prisma } from '@/lib/prisma';
import { generateReferralCode } from '@/lib/referral-code';

const applicationSchema = z.object({
  email: z.string().email(),
  password: z.string().min(8),
  firstName: z.string().min(1),
  lastName: z.string().min(1),
  companyName: z.string().optional(),
  phone: z.string().optional(),
  website: z.string().url().optional().or(z.literal('')),
  taxId: z.string().optional(),
});

export async function POST(request: Request) {
  try {
    const body = await request.json();
    const data = applicationSchema.parse(body);

    // Check if email already exists
    const existingPartner = await prisma.partner.findUnique({
      where: { email: data.email },
    });

    if (existingPartner) {
      return NextResponse.json(
        { error: 'Email already registered' },
        { status: 400 }
      );
    }

    // Hash password
    const passwordHash = await bcrypt.hash(data.password, 10);

    // Generate unique referral code
    let referralCode = generateReferralCode();
    let codeExists = await prisma.partner.findUnique({
      where: { referralCode },
    });

    while (codeExists) {
      referralCode = generateReferralCode();
      codeExists = await prisma.partner.findUnique({
        where: { referralCode },
      });
    }

    // Create partner
    const partner = await prisma.partner.create({
      data: {
        email: data.email,
        passwordHash,
        firstName: data.firstName,
        lastName: data.lastName,
        companyName: data.companyName,
        phone: data.phone,
        website: data.website || null,
        taxId: data.taxId,
        referralCode,
        status: 'PENDING',
        tier: 'BRONZE',
      },
    });

    // TODO: Send welcome email
    // TODO: Notify admin of new application

    return NextResponse.json({
      success: true,
      message: 'Application submitted successfully. You will be notified once approved.',
      partnerId: partner.id,
    });
  } catch (error) {
    if (error instanceof z.ZodError) {
      return NextResponse.json(
        { error: 'Invalid input', details: error.errors },
        { status: 400 }
      );
    }

    console.error('Partner application error:', error);
    return NextResponse.json(
      { error: 'Internal server error' },
      { status: 500 }
    );
  }
}
