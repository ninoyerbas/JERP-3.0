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

namespace JERP.Core.Enums;

/// <summary>
/// Status of a license in the system
/// </summary>
public enum LicenseStatus
{
    /// <summary>
    /// License is active and valid
    /// </summary>
    Active = 0,

    /// <summary>
    /// License has expired and needs renewal
    /// </summary>
    Expired = 1,

    /// <summary>
    /// License is temporarily suspended (e.g., payment failure)
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// License is invalid or revoked
    /// </summary>
    Invalid = 3,

    /// <summary>
    /// Trial period has expired
    /// </summary>
    TrialExpired = 4
}
