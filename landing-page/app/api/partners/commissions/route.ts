import { NextResponse } from 'next/server';
import { getServerSession } from 'next-auth';
import { authOptions } from '@/lib/auth';
import { prisma } from '@/lib/prisma';

export async function GET(request: Request) {
  try {
    const session = await getServerSession(authOptions);

    if (!session || !session.user?.id) {
      return NextResponse.json(
        { error: 'Unauthorized' },
        { status: 401 }
      );
    }

    const url = new URL(request.url);
    const page = parseInt(url.searchParams.get('page') || '1');
    const limit = parseInt(url.searchParams.get('limit') || '10');
    const type = url.searchParams.get('type');
    const status = url.searchParams.get('status');
    const skip = (page - 1) * limit;

    const where = {
      partnerId: session.user.id,
      ...(type && { type: type as any }),
      ...(status && { status: status as any }),
    };

    const [commissions, total] = await Promise.all([
      prisma.commission.findMany({
        where,
        include: {
          referral: {
            select: {
              customerEmail: true,
              customerName: true,
              plan: true,
            },
          },
        },
        orderBy: {
          createdAt: 'desc',
        },
        skip,
        take: limit,
      }),
      prisma.commission.count({ where }),
    ]);

    return NextResponse.json({
      commissions,
      pagination: {
        page,
        limit,
        total,
        pages: Math.ceil(total / limit),
      },
    });
  } catch (error) {
    console.error('Get commissions error:', error);
    return NextResponse.json(
      { error: 'Internal server error' },
      { status: 500 }
    );
  }
}
