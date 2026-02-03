import { PartnerTier } from '@prisma/client';

// Pricing tiers for JERP
export const PRICING = {
  FREE: { base: 0, perEmployee: 0, maxEmployees: 5 },
  STARTER: { base: 19, perEmployee: 2.5 },
  PRO: { base: 39, perEmployee: 3.5 },
  ENTERPRISE: { base: 99, perEmployee: 4.5 },
};

// Commission rates by tier
export const COMMISSION_RATES = {
  BRONZE: 0.25,
  SILVER: 0.30,
  GOLD: 0.35,
};

// Signup bonuses by tier
export const SIGNUP_BONUSES = {
  BRONZE: 75,
  SILVER: 100,
  GOLD: 125,
};

// Tier thresholds
export const TIER_THRESHOLDS = {
  SILVER: 6,  // 6-15 active customers
  GOLD: 16,   // 16+ active customers
};

/**
 * Calculate MRR for a plan
 */
export function calculateMRR(plan: string, employeeCount: number): number {
  const planKey = plan.toUpperCase() as keyof typeof PRICING;
  const pricing = PRICING[planKey];
  
  if (!pricing) return 0;
  
  return pricing.base + (pricing.perEmployee * employeeCount);
}

/**
 * Calculate recurring commission
 */
export function calculateRecurringCommission(mrr: number, tier: PartnerTier): number {
  const rate = COMMISSION_RATES[tier];
  return mrr * rate;
}

/**
 * Get signup bonus for tier
 */
export function getSignupBonus(tier: PartnerTier): number {
  return SIGNUP_BONUSES[tier];
}

/**
 * Determine tier based on active customer count
 */
export function determineTier(activeCustomers: number): PartnerTier {
  if (activeCustomers >= TIER_THRESHOLDS.GOLD) {
    return 'GOLD';
  } else if (activeCustomers >= TIER_THRESHOLDS.SILVER) {
    return 'SILVER';
  }
  return 'BRONZE';
}

/**
 * Calculate commission rate for tier
 */
export function getCommissionRate(tier: PartnerTier): number {
  return COMMISSION_RATES[tier];
}
