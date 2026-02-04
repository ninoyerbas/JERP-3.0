/**
 * Generate a unique referral code
 */
export function generateReferralCode(): string {
  const chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
  let code = '';
  for (let i = 0; i < 8; i++) {
    code += chars.charAt(Math.floor(Math.random() * chars.length));
  }
  return code;
}

/**
 * Generate a secure referral URL
 */
export function generateReferralURL(referralCode: string, baseURL: string): string {
  return `${baseURL}/signup?ref=${referralCode}`;
}
