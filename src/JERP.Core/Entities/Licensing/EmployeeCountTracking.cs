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
/// Tracks employee count changes over time for a license
/// </summary>
public class EmployeeCountTracking : BaseEntity
{
    /// <summary>
    /// Foreign key to the license
    /// </summary>
    [Required]
    public Guid LicenseId { get; set; }

    /// <summary>
    /// Number of employees at this point in time
    /// </summary>
    [Required]
    public int EmployeeCount { get; set; }

    /// <summary>
    /// When this count was recorded
    /// </summary>
    [Required]
    public DateTime RecordedAt { get; set; }

    // Navigation properties
    public License License { get; set; } = null!;
}
