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

namespace JERP.Application.Services.Licensing;

/// <summary>
/// Details for a subscription plan
/// </summary>
public class PlanDetails
{
    public string Name { get; set; } = string.Empty;
    public SubscriptionPlan Plan { get; set; }
    public decimal MonthlyPrice { get; set; }
    public decimal AnnualPrice { get; set; }
    public int MaxEmployees { get; set; }
    public int MaxCompanies { get; set; }
    public string[] Features { get; set; } = Array.Empty<string>();
    public int StorageGB { get; set; }
    public string SupportLevel { get; set; } = string.Empty;
    public string SupportResponseTime { get; set; } = string.Empty;
}
