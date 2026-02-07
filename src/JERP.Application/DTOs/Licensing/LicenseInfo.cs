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
/// Information about a license
/// </summary>
public class LicenseInfo
{
    public string LicenseKey { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public SubscriptionPlan Plan { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int MaxEmployees { get; set; }
    public int CurrentEmployees { get; set; }
    public int MaxCompanies { get; set; }
    public int CurrentCompanies { get; set; }
    public List<string> EnabledFeatures { get; set; } = new();
    public string? MachineId { get; set; }
    public LicenseStatus Status { get; set; }
    
    /// <summary>
    /// Checks if another employee can be added
    /// </summary>
    public bool CanAddEmployee() => CurrentEmployees < MaxEmployees;
    
    /// <summary>
    /// Gets remaining employee slots
    /// </summary>
    public int RemainingEmployeeSlots() => Math.Max(0, MaxEmployees - CurrentEmployees);
    
    /// <summary>
    /// Checks if license is expiring soon (within 7 days)
    /// </summary>
    public bool IsExpiringSoon() => (ExpirationDate - DateTime.UtcNow).TotalDays <= 7 && (ExpirationDate - DateTime.UtcNow).TotalDays > 0;
    
    /// <summary>
    /// Checks if license is expired
    /// </summary>
    public bool IsExpired() => DateTime.UtcNow > ExpirationDate;
    
    /// <summary>
    /// Checks if this is a trial license
    /// </summary>
    public bool IsTrial() => Plan == SubscriptionPlan.Trial;

    /// <summary>
    /// Checks if another company can be added
    /// </summary>
    public bool CanAddCompany() => CurrentCompanies < MaxCompanies;
}
