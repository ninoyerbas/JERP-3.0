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

using System.ComponentModel.DataAnnotations;
using JERP.Core.Enums;

namespace JERP.Core.Entities.Licensing;

/// <summary>
/// Represents a license key and subscription in the system
/// </summary>
public class License : BaseEntity
{
    /// <summary>
    /// Unique license key for activation
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string LicenseKey { get; set; } = string.Empty;

    /// <summary>
    /// Name of the customer who owns this license
    /// </summary>
    [Required]
    [MaxLength(200)]
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Email address of the customer
    /// </summary>
    [Required]
    [EmailAddress]
    [MaxLength(200)]
    public string CustomerEmail { get; set; } = string.Empty;

    /// <summary>
    /// Current subscription plan
    /// </summary>
    [Required]
    public SubscriptionPlan Plan { get; set; }

    /// <summary>
    /// Date when the license was issued
    /// </summary>
    [Required]
    public DateTime IssueDate { get; set; }

    /// <summary>
    /// Date when the license expires
    /// </summary>
    [Required]
    public DateTime ExpirationDate { get; set; }

    /// <summary>
    /// Maximum number of employees allowed for this plan
    /// </summary>
    [Required]
    public int MaxEmployees { get; set; }

    /// <summary>
    /// Current number of active employees
    /// </summary>
    [Required]
    public int CurrentEmployees { get; set; }

    /// <summary>
    /// Maximum number of companies allowed for this plan
    /// </summary>
    [Required]
    public int MaxCompanies { get; set; }

    /// <summary>
    /// Current number of active companies
    /// </summary>
    [Required]
    public int CurrentCompanies { get; set; }

    /// <summary>
    /// Machine identifier for activation binding (null if not activated)
    /// </summary>
    [MaxLength(200)]
    public string? MachineId { get; set; }

    /// <summary>
    /// Current status of the license
    /// </summary>
    [Required]
    public LicenseStatus Status { get; set; } = LicenseStatus.Active;

    /// <summary>
    /// Stripe customer ID for payment processing
    /// </summary>
    [MaxLength(100)]
    public string? StripeCustomerId { get; set; }

    /// <summary>
    /// Stripe subscription ID for recurring payments
    /// </summary>
    [MaxLength(100)]
    public string? StripeSubscriptionId { get; set; }

    /// <summary>
    /// Whether the subscription is on annual billing
    /// </summary>
    public bool IsAnnualBilling { get; set; }

    /// <summary>
    /// Last time the license was validated online
    /// </summary>
    public DateTime? LastValidatedAt { get; set; }

    // Navigation properties
    public ICollection<PlanFeature> EnabledFeatures { get; set; } = new List<PlanFeature>();
    public ICollection<SubscriptionHistory> SubscriptionHistory { get; set; } = new List<SubscriptionHistory>();
    public ICollection<EmployeeCountTracking> EmployeeCountHistory { get; set; } = new List<EmployeeCountTracking>();

    // Business logic methods
    /// <summary>
    /// Checks if another employee can be added based on the plan limits
    /// </summary>
    public bool CanAddEmployee() => CurrentEmployees < MaxEmployees;

    /// <summary>
    /// Gets the number of remaining employee slots available
    /// </summary>
    public int RemainingEmployeeSlots() => Math.Max(0, MaxEmployees - CurrentEmployees);

    /// <summary>
    /// Checks if the license is expiring soon (within 7 days)
    /// </summary>
    public bool IsExpiringSoon() => (ExpirationDate - DateTime.UtcNow).TotalDays <= 7 && (ExpirationDate - DateTime.UtcNow).TotalDays > 0;

    /// <summary>
    /// Checks if the license is currently expired
    /// </summary>
    public bool IsExpired() => DateTime.UtcNow > ExpirationDate;

    /// <summary>
    /// Checks if this is a trial license
    /// </summary>
    public bool IsTrial() => Plan == SubscriptionPlan.Trial;

    /// <summary>
    /// Checks if another company can be added based on the plan limits
    /// </summary>
    public bool CanAddCompany() => CurrentCompanies < MaxCompanies;
}
