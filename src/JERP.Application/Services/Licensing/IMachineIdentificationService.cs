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

namespace JERP.Application.Services.Licensing;

/// <summary>
/// Service for machine identification and binding
/// </summary>
public interface IMachineIdentificationService
{
    /// <summary>
    /// Gets a unique machine identifier
    /// </summary>
    string GetMachineId();

    /// <summary>
    /// Validates that a license is activated on this machine
    /// </summary>
    Task<bool> ValidateMachineAsync(string licenseKey, string machineId);
}
