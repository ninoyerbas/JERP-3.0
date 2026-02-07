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
/// Service for feature gating based on license
/// </summary>
public interface IFeatureGuard
{
    /// <summary>
    /// Checks if a feature is accessible with current license
    /// </summary>
    Task<bool> CanAccessFeatureAsync(string featureName);

    /// <summary>
    /// Requires a feature and shows upgrade prompt if not available
    /// </summary>
    Task<bool> RequireFeatureAsync(string featureName, string featureDisplayName);
}
