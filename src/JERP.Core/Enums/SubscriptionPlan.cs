/*
 * JERP 3.0 - Payroll & ERP System
 * Copyright (c) 2026 Julio Cesar Mendez Tobar. All Rights Reserved.
 * 
 * PROPRIETARY AND CONFIDENTIAL
 * 
 * This source code is the confidential and proprietary information of Julio Cesar Mendez Tobar.
 * Unauthorized copying, modification, distribution, or use is strictly prohibited.
 * 
 * For licensing inquiries: ichbincesartobar@yahoo.com
 */

namespace JERP.Core.Enums;

/// <summary>
/// Subscription plans available in JERP 3.0
/// Based on employee count tiers
/// </summary>
public enum SubscriptionPlan
{
    /// <summary>
    /// 14-day trial with Professional features, limited to 3 employees and 1 company
    /// </summary>
    Trial = 0,

    /// <summary>
    /// Starter Plan: $79/month - Up to 3 employees, 1 company
    /// Basic accounting, simple invoicing, mobile app access
    /// </summary>
    Starter = 1,

    /// <summary>
    /// Small Business Plan: $149/month - Up to 10 employees, 2 companies
    /// Core accounting, basic payroll, invoicing, purchase orders, basic job costing
    /// </summary>
    SmallBusiness = 2,

    /// <summary>
    /// Professional Plan: $299/month - Up to 50 employees, 5 companies (MOST POPULAR)
    /// Certified payroll, prevailing wage, advanced job costing, AIA billing, GPS time tracking
    /// </summary>
    Professional = 3,

    /// <summary>
    /// Enterprise Plan: $599/month - Up to 150 employees, unlimited companies
    /// Multi-company consolidation, advanced compliance, custom workflows, white-label options
    /// </summary>
    Enterprise = 4,

    /// <summary>
    /// Ultimate Plan: $999/month - Unlimited employees and companies
    /// Custom development, 24/7 support, on-premise deployment, SLA guarantee
    /// </summary>
    Ultimate = 5
}
