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

namespace JERP.Core.Entities.Licensing;

/// <summary>
/// Represents a feature that is enabled for a specific license/plan
/// </summary>
public class PlanFeature : BaseEntity
{
    /// <summary>
    /// Foreign key to the license
    /// </summary>
    [Required]
    public Guid LicenseId { get; set; }

    /// <summary>
    /// Internal feature code name (e.g., "CertifiedPayroll", "APIAccess")
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string FeatureCode { get; set; } = string.Empty;

    /// <summary>
    /// Display name for the feature
    /// </summary>
    [Required]
    [MaxLength(200)]
    public string FeatureName { get; set; } = string.Empty;

    /// <summary>
    /// Whether this feature is currently enabled
    /// </summary>
    public bool IsEnabled { get; set; } = true;

    // Navigation properties
    public License License { get; set; } = null!;
}
