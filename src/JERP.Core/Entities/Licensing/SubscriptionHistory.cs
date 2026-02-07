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
/// Tracks subscription changes and history for a license
/// </summary>
public class SubscriptionHistory : BaseEntity
{
    /// <summary>
    /// Foreign key to the license
    /// </summary>
    [Required]
    public Guid LicenseId { get; set; }

    /// <summary>
    /// The plan at the time of this history entry
    /// </summary>
    [Required]
    public SubscriptionPlan Plan { get; set; }

    /// <summary>
    /// Action that occurred (Created, Upgraded, Downgraded, Renewed, Cancelled)
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// Additional details about the action
    /// </summary>
    [MaxLength(500)]
    public string? Details { get; set; }

    /// <summary>
    /// When this action occurred
    /// </summary>
    [Required]
    public DateTime OccurredAt { get; set; }

    // Navigation properties
    public License License { get; set; } = null!;
}
