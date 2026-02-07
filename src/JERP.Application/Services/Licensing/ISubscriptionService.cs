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

using JERP.Application.DTOs.Licensing;
using JERP.Core.Enums;

namespace JERP.Application.Services.Licensing;

/// <summary>
/// Service for subscription management and billing
/// </summary>
public interface ISubscriptionService
{
    /// <summary>
    /// Gets current subscription status
    /// </summary>
    Task<SubscriptionStatus> GetSubscriptionStatusAsync();

    /// <summary>
    /// Creates a Stripe checkout session for a new subscription
    /// </summary>
    Task<string> CreateCheckoutSessionAsync(SubscriptionPlan plan, bool isAnnual);

    /// <summary>
    /// Upgrades the current plan
    /// </summary>
    Task<bool> UpgradePlanAsync(SubscriptionPlan newPlan);

    /// <summary>
    /// Downgrades the current plan
    /// </summary>
    Task<bool> DowngradePlanAsync(SubscriptionPlan newPlan);

    /// <summary>
    /// Cancels the current subscription
    /// </summary>
    Task<bool> CancelSubscriptionAsync();

    /// <summary>
    /// Gets invoice history
    /// </summary>
    Task<List<InvoiceDto>> GetInvoiceHistoryAsync();

    /// <summary>
    /// Activates a trial subscription
    /// </summary>
    Task<LicenseInfo> ActivateTrialAsync(string customerName, string customerEmail, string machineId);
}

/// <summary>
/// Invoice DTO
/// </summary>
public class InvoiceDto
{
    public string InvoiceId { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? PdfUrl { get; set; }
}
