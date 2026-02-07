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

namespace JERP.Application.Services.Licensing;

/// <summary>
/// Service for license validation and management
/// </summary>
public interface ILicenseService
{
    /// <summary>
    /// Validates a license key
    /// </summary>
    Task<LicenseValidationResult> ValidateLicenseAsync(string licenseKey);

    /// <summary>
    /// Activates a license on this machine
    /// </summary>
    Task<bool> ActivateLicenseAsync(string licenseKey, string machineId);

    /// <summary>
    /// Gets current license information
    /// </summary>
    Task<LicenseInfo?> GetLicenseInfoAsync();

    /// <summary>
    /// Checks if a specific feature is enabled
    /// </summary>
    Task<bool> IsFeatureEnabledAsync(string featureName);

    /// <summary>
    /// Checks if another employee can be added
    /// </summary>
    Task<bool> CanAddEmployeeAsync();

    /// <summary>
    /// Gets remaining employee slots
    /// </summary>
    Task<int> GetRemainingEmployeeSlotsAsync();

    /// <summary>
    /// Checks if the license is valid
    /// </summary>
    bool IsLicenseValid();

    /// <summary>
    /// Checks if the trial has expired
    /// </summary>
    bool IsTrialExpired();

    /// <summary>
    /// Updates employee count for the current license
    /// </summary>
    Task UpdateEmployeeCountAsync(int count);

    /// <summary>
    /// Updates company count for the current license
    /// </summary>
    Task UpdateCompanyCountAsync(int count);

    /// <summary>
    /// Checks if another company can be added
    /// </summary>
    Task<bool> CanAddCompanyAsync();
}
