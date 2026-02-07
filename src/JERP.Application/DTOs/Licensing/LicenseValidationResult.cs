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

namespace JERP.Application.DTOs.Licensing;

/// <summary>
/// Result of license validation
/// </summary>
public class LicenseValidationResult
{
    public bool IsValid { get; set; }
    public LicenseInfo? License { get; set; }
    public string? ErrorMessage { get; set; }
}
