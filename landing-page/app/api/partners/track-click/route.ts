import { NextResponse } from 'next/server';
import { prisma } from '@/lib/prisma';

export async function POST(request: Request) {
  try {
    const { referralCode } = await request.json();

    if (!referralCode) {
      return NextResponse.json(
        { error: 'Referral code required' },
        { status: 400 }
      );
    }

    // Lookup partner
    const partner = await prisma.partner.findUnique({
      where: { referralCode },
    });

    if (!partner || partner.status !== 'ACTIVE') {
      return NextResponse.json(
        { error: 'Invalid referral code' },
        { status: 404 }
      );
    }

    // Get request metadata
    const ip = request.headers.get('x-forwarded-for') || request.headers.get('x-real-ip') || 'unknown';
    const userAgent = request.headers.get('user-agent') || '';
    const referrer = request.headers.get('referer') || '';

    // Parse UTM params from request URL
    const url = new URL(request.url);
    const utmSource = url.searchParams.get('utm_source');
    const utmMedium = url.searchParams.get('utm_medium');
    const utmCampaign = url.searchParams.get('utm_campaign');

    // Log click
    await prisma.referralClick.create({
      data: {
        partnerId: partner.id,
        ipAddress: ip,
        userAgent,
        referrer,
        utmSource,
        utmMedium,
        utmCampaign,
      },
    });

    // Set 30-day attribution cookie
    const response = NextResponse.json({ success: true });
    response.cookies.set('jerp_ref', referralCode, {
      maxAge: 30 * 24 * 60 * 60, // 30 days
      httpOnly: true,
      secure: process.env.NODE_ENV === 'production',
      sameSite: 'lax',
      path: '/',
    });

    return response;
  } catch (error) {
    console.error('Track click error:', error);
    return NextResponse.json(
      { error: 'Internal server error' },
      { status: 500 }
    );
  }
}
