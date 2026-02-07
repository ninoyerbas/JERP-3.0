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

namespace JERP.Application.Services.Licensing;

/// <summary>
/// Configuration for all subscription plans
/// </summary>
public static class PlanConfiguration
{
    /// <summary>
    /// Gets detailed information for a specific subscription plan
    /// </summary>
    public static PlanDetails GetPlanDetails(SubscriptionPlan plan)
    {
        return plan switch
        {
            SubscriptionPlan.Trial => new PlanDetails
            {
                Name = "Trial",
                Plan = SubscriptionPlan.Trial,
                MonthlyPrice = 0m,
                AnnualPrice = 0m,
                MaxEmployees = 3,
                MaxCompanies = 1,
                Features = new[] 
                { 
                    "CoreAccounting", "BasicPayroll", "Invoicing", "PurchaseOrders", 
                    "BasicJobCosting", "MobileApp", "CertifiedPayroll", "PrevailingWage", 
                    "GPSTimeTracking", "AdvancedJobCosting", "ChangeOrders", "AIABilling", 
                    "LienWaivers", "EquipmentTracking", "SubcontractorManagement", "AdvancedReporting" 
                },
                StorageGB = 10,
                SupportLevel = "Email",
                SupportResponseTime = "72 hours"
            },
            SubscriptionPlan.Starter => new PlanDetails
            {
                Name = "Starter",
                Plan = SubscriptionPlan.Starter,
                MonthlyPrice = 79m,
                AnnualPrice = 854m, // 10% discount (approximately 2 months free)
                MaxEmployees = 3,
                MaxCompanies = 1,
                Features = new[] { "CoreAccounting", "BasicInvoicing", "CustomerVendorManagement", "MobileApp" },
                StorageGB = 10,
                SupportLevel = "Email",
                SupportResponseTime = "72 hours"
            },
            SubscriptionPlan.SmallBusiness => new PlanDetails
            {
                Name = "Small Business",
                Plan = SubscriptionPlan.SmallBusiness,
                MonthlyPrice = 149m,
                AnnualPrice = 1609m,
                MaxEmployees = 10,
                MaxCompanies = 2,
                Features = new[] 
                { 
                    "CoreAccounting", "BasicPayroll", "Invoicing", "Bills", 
                    "PurchaseOrders", "BasicJobCosting", "BankReconciliation", 
                    "MobileApp", "BasicReporting" 
                },
                StorageGB = 25,
                SupportLevel = "Email",
                SupportResponseTime = "48 hours"
            },
            SubscriptionPlan.Professional => new PlanDetails
            {
                Name = "Professional",
                Plan = SubscriptionPlan.Professional,
                MonthlyPrice = 299m,
                AnnualPrice = 3229m,
                MaxEmployees = 50,
                MaxCompanies = 5,
                Features = new[] 
                { 
                    "AllSmallBusinessFeatures", "CertifiedPayroll", "PrevailingWage", 
                    "UnionNonUnionClassifications", "AdvancedJobCosting", "ChangeOrders", 
                    "AIABilling", "LienWaivers", "EquipmentTracking", "GPSTimeTracking", 
                    "SubcontractorManagement", "AdvancedReporting", "Dashboards", 
                    "APIAccess", "PrioritySupport", "PhoneSupport" 
                },
                StorageGB = 100,
                SupportLevel = "Email + Phone (business hours)",
                SupportResponseTime = "24 hours"
            },
            SubscriptionPlan.Enterprise => new PlanDetails
            {
                Name = "Enterprise",
                Plan = SubscriptionPlan.Enterprise,
                MonthlyPrice = 599m,
                AnnualPrice = 6469m,
                MaxEmployees = 150,
                MaxCompanies = int.MaxValue, // Unlimited
                Features = new[] 
                { 
                    "AllProfessionalFeatures", "MultiCompanyConsolidation", "AdvancedCompliance", 
                    "OSHACompliance", "MultiStateCompliance", "CustomWorkflows", "ApprovalWorkflows", 
                    "SubcontractorPortal", "DocumentManagement", "AdvancedAnalytics", 
                    "RoleBasedPermissions", "WhiteLabel", "DedicatedAccountManager", 
                    "CustomIntegrations", "QuarterlyBusinessReview" 
                },
                StorageGB = 500,
                SupportLevel = "Priority Phone",
                SupportResponseTime = "12 hours"
            },
            SubscriptionPlan.Ultimate => new PlanDetails
            {
                Name = "Ultimate",
                Plan = SubscriptionPlan.Ultimate,
                MonthlyPrice = 999m,
                AnnualPrice = 10789m,
                MaxEmployees = int.MaxValue, // Unlimited
                MaxCompanies = int.MaxValue, // Unlimited
                Features = new[] 
                { 
                    "AllEnterpriseFeatures", "CustomDevelopment", "DedicatedSupportTeam", 
                    "247Support", "OnPremiseDeployment", "SLAGuarantee", "UnlimitedStorage", 
                    "WhiteGloveOnboarding", "MonthlyBusinessReview", "UnlimitedIntegrations", 
                    "EarlyFeatureAccess" 
                },
                StorageGB = int.MaxValue, // Unlimited
                SupportLevel = "24/7 Dedicated Team",
                SupportResponseTime = "1 hour"
            },
            _ => throw new ArgumentException($"Invalid subscription plan: {plan}")
        };
    }

    /// <summary>
    /// Gets all available plans
    /// </summary>
    public static List<PlanDetails> GetAllPlans()
    {
        return new List<PlanDetails>
        {
            GetPlanDetails(SubscriptionPlan.Starter),
            GetPlanDetails(SubscriptionPlan.SmallBusiness),
            GetPlanDetails(SubscriptionPlan.Professional),
            GetPlanDetails(SubscriptionPlan.Enterprise),
            GetPlanDetails(SubscriptionPlan.Ultimate)
        };
    }

    /// <summary>
    /// Gets all available paid plans (excludes Trial)
    /// </summary>
    public static List<PlanDetails> GetPaidPlans()
    {
        return GetAllPlans().Where(p => p.Plan != SubscriptionPlan.Trial).ToList();
    }
}
