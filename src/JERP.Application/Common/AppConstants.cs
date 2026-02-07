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

namespace JERP.Application.Common;

/// <summary>
/// Application-wide constants and configuration values
/// </summary>
public static class AppConstants
{
    #region Developer Information
    
    /// <summary>
    /// Developer name
    /// </summary>
    public const string DeveloperName = "Julio Cesar Mendez Tobar Jr.";
    
    /// <summary>
    /// Primary developer email
    /// </summary>
    public const string DeveloperEmail = "ichbincesartobar@yahoo.com";
    
    /// <summary>
    /// Alternate developer email
    /// </summary>
    public const string DeveloperEmailAlt = "ichbincesartobar@gmail.com";
    
    /// <summary>
    /// Support email for customers
    /// </summary>
    public const string SupportEmail = "support@jerp3.com";
    
    /// <summary>
    /// About developer text
    /// </summary>
    public const string AboutDeveloper = @"JERP 3.0 - Construction ERP System

Developed by Julio Cesar Mendez Tobar Jr.

Education:
• Universidad de El Salvador - Business Administration
  Facultad Multidisciplinaria de Occidente
• UC Davis - Construction Project Management

Background:
• 10+ years construction industry experience
• Project manager who learned to code
• Building affordable tools for contractors

Built by a contractor, for contractors.

Contact: ichbincesartobar@yahoo.com";

    #endregion

    #region Application Information
    
    /// <summary>
    /// Application name
    /// </summary>
    public const string ApplicationName = "JERP 3.0";
    
    /// <summary>
    /// Application description
    /// </summary>
    public const string ApplicationDescription = "Construction ERP & Payroll System";
    
    /// <summary>
    /// Current version
    /// </summary>
    public const string Version = "3.0.0";
    
    #endregion

    #region Licensing Messages (use "employees" NOT "users")
    
    /// <summary>
    /// Message when employee limit is reached
    /// </summary>
    public const string EmployeeLimitReachedMessage = "You've reached your employee limit for this plan.";
    
    /// <summary>
    /// Label for adding employees
    /// </summary>
    public const string AddEmployeeLabel = "Add Employee";
    
    /// <summary>
    /// Label for maximum employees
    /// </summary>
    public const string MaxEmployeesLabel = "Maximum Employees";
    
    /// <summary>
    /// Label for current employees
    /// </summary>
    public const string CurrentEmployeesLabel = "Current Employees";
    
    /// <summary>
    /// Label for available employee slots
    /// </summary>
    public const string AvailableEmployeeSlotsLabel = "Available Employee Slots";
    
    /// <summary>
    /// Message template for employee limit warning (80% threshold)
    /// </summary>
    public const string EmployeeLimitWarningTemplate = "You're approaching your employee limit ({0}/{1} employees). Consider upgrading your plan.";
    
    /// <summary>
    /// Message template for upgrade prompt
    /// </summary>
    public const string UpgradePromptTemplate = "Your {0} plan allows up to {1} employees. You currently have {2} employees. Upgrade to add more employees?";
    
    /// <summary>
    /// Company limit reached message
    /// </summary>
    public const string CompanyLimitReachedMessage = "You've reached your company limit for this plan.";
    
    /// <summary>
    /// Trial expired message
    /// </summary>
    public const string TrialExpiredMessage = "Your 14-day trial has expired. Subscribe to continue using JERP 3.0.";
    
    /// <summary>
    /// License expired message
    /// </summary>
    public const string LicenseExpiredMessage = "Your license has expired. Please renew your subscription.";
    
    /// <summary>
    /// License expiring soon message template (days remaining)
    /// </summary>
    public const string LicenseExpiringSoonTemplate = "Your license expires in {0} days. Renew now to avoid interruption.";
    
    #endregion

    #region Feature Names
    
    /// <summary>
    /// Feature names for gating
    /// </summary>
    public static class Features
    {
        public const string CoreAccounting = "CoreAccounting";
        public const string BasicPayroll = "BasicPayroll";
        public const string CertifiedPayroll = "CertifiedPayroll";
        public const string PrevailingWage = "PrevailingWage";
        public const string AdvancedJobCosting = "AdvancedJobCosting";
        public const string ChangeOrders = "ChangeOrders";
        public const string AIABilling = "AIABilling";
        public const string LienWaivers = "LienWaivers";
        public const string EquipmentTracking = "EquipmentTracking";
        public const string GPSTimeTracking = "GPSTimeTracking";
        public const string SubcontractorManagement = "SubcontractorManagement";
        public const string AdvancedReporting = "AdvancedReporting";
        public const string APIAccess = "APIAccess";
        public const string MultiCompanyConsolidation = "MultiCompanyConsolidation";
        public const string CustomWorkflows = "CustomWorkflows";
        public const string DocumentManagement = "DocumentManagement";
        public const string WhiteLabel = "WhiteLabel";
        public const string CustomDevelopment = "CustomDevelopment";
        public const string OnPremiseDeployment = "OnPremiseDeployment";
    }
    
    #endregion

    #region Trial Configuration
    
    /// <summary>
    /// Trial duration in days
    /// </summary>
    public const int TrialDurationDays = 14;
    
    /// <summary>
    /// Grace period after trial expiration in days
    /// </summary>
    public const int TrialGracePeriodDays = 3;
    
    /// <summary>
    /// Offline grace period in days
    /// </summary>
    public const int OfflineGracePeriodDays = 7;
    
    #endregion

    #region URLs
    
    /// <summary>
    /// License server URL
    /// </summary>
    public const string LicenseServerUrl = "https://license.jerp3.com";
    
    /// <summary>
    /// Application URL
    /// </summary>
    public const string ApplicationUrl = "https://app.jerp3.com";
    
    /// <summary>
    /// Website URL
    /// </summary>
    public const string WebsiteUrl = "https://jerp3.com";
    
    #endregion
}
