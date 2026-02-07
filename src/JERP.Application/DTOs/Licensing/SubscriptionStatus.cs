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

using JERP.Core.Enums;

namespace JERP.Application.DTOs.Licensing;

/// <summary>
/// Current status of a subscription
/// </summary>
public class SubscriptionStatus
{
    public bool IsActive { get; set; }
    public SubscriptionPlan Plan { get; set; }
    public DateTime CurrentPeriodEnd { get; set; }
    public bool WillRenew { get; set; }
    public decimal NextPaymentAmount { get; set; }
    public List<string> EnabledFeatures { get; set; } = new();
    public int MaxEmployees { get; set; }
    public int CurrentEmployees { get; set; }
    public int MaxCompanies { get; set; }
    public int CurrentCompanies { get; set; }
}
