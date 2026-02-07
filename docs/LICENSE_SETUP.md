# JERP 3.0 License Setup Guide

## Overview

This guide explains how to set up, configure, and manage the licensing system for JERP 3.0.

---

## Architecture

### Components

1. **License Entities** (`JERP.Core.Entities.Licensing`)
   - `License` - Main license/subscription record
   - `PlanFeature` - Features enabled for each license
   - `SubscriptionHistory` - Audit trail of plan changes
   - `EmployeeCountTracking` - Historical employee count tracking

2. **License Services** (`JERP.Application.Services.Licensing`)
   - `ILicenseService` - License validation and management
   - `ISubscriptionService` - Subscription and billing operations
   - `IMachineIdentificationService` - Machine binding for licenses
   - `IFeatureGuard` - Feature gating based on subscription

3. **Database Tables**
   - `Licenses` - Core license data
   - `PlanFeatures` - Feature flags per license
   - `SubscriptionHistory` - Change history
   - `EmployeeCountTracking` - Employee count history

---

## Configuration

### appsettings.json

Add licensing configuration to `appsettings.json`:

```json
{
  "Licensing": {
    "LicenseServerUrl": "https://license.jerp3.com",
    "OfflineGracePeriodDays": 7,
    "TrialDurationDays": 14,
    "TrialGracePeriodDays": 3,
    "EnableLicenseValidation": true
  },
  "Stripe": {
    "PublishableKey": "pk_live_...",
    "SecretKey": "sk_live_...",
    "WebhookSecret": "whsec_...",
    "EnablePayments": true
  },
  "ContactInfo": {
    "DeveloperName": "Julio Cesar Mendez Tobar Jr.",
    "Email": "ichbincesartobar@yahoo.com",
    "AlternateEmail": "ichbincesartobar@gmail.com",
    "SupportEmail": "support@jerp3.com",
    "Website": "https://jerp3.com"
  }
}
```

### Environment Variables (Optional)

For production deployments, use environment variables:

```bash
JERP_LICENSING__LICENSESERVERURL=https://license.jerp3.com
JERP_LICENSING__ENABLELICENSEVALIDATION=true
JERP_STRIPE__SECRETKEY=sk_live_...
JERP_STRIPE__WEBHOOKSECRET=whsec_...
```

---

## Database Setup

### 1. Run Migrations

The licensing tables are created via EF Core migrations:

```bash
cd src/JERP.Infrastructure
dotnet ef database update
```

This creates:
- `Licenses` table
- `PlanFeatures` table
- `SubscriptionHistory` table
- `EmployeeCountTracking` table

### 2. Verify Tables

Connect to SQL Server and verify:

```sql
-- Check if tables exist
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME IN ('Licenses', 'PlanFeatures', 'SubscriptionHistory', 'EmployeeCountTracking');

-- View License table structure
EXEC sp_help 'dbo.Licenses';
```

---

## Subscription Plans

### Plan Configuration

Plans are defined in `PlanConfiguration.cs`:

| Plan | Monthly | Annual | Employees | Companies | Features |
|------|---------|--------|-----------|-----------|----------|
| Trial | $0 | $0 | 3 | 1 | Full Professional |
| Starter | $79 | $854 | 3 | 1 | Basic |
| Small Business | $149 | $1,609 | 10 | 2 | Core + Payroll |
| Professional | $299 | $3,229 | 50 | 5 | Advanced + Certified Payroll |
| Enterprise | $599 | $6,469 | 150 | Unlimited | Everything + Multi-Company |
| Ultimate | $999 | $10,789 | Unlimited | Unlimited | Custom + 24/7 Support |

### Adding a New Plan

1. Add to `SubscriptionPlan` enum:
```csharp
public enum SubscriptionPlan
{
    // ... existing plans
    NewPlan = 6
}
```

2. Add plan details to `PlanConfiguration.GetPlanDetails()`:
```csharp
SubscriptionPlan.NewPlan => new PlanDetails
{
    Name = "New Plan",
    MonthlyPrice = 399m,
    AnnualPrice = 4309m,
    MaxEmployees = 75,
    MaxCompanies = 10,
    Features = new[] { "Feature1", "Feature2" }
}
```

---

## Trial Management

### Trial Configuration

Trials are configured in `AppConstants.cs`:

```csharp
public const int TrialDurationDays = 14;
public const int TrialGracePeriodDays = 3;
public const int OfflineGracePeriodDays = 7;
```

### Trial Activation Flow

1. **User requests trial**
   ```csharp
   var license = await _subscriptionService.ActivateTrialAsync(
       customerName: "John Doe Construction",
       customerEmail: "john@example.com",
       machineId: _machineIdService.GetMachineId()
   );
   ```

2. **Trial license created**
   - Plan: `SubscriptionPlan.Trial`
   - Duration: 14 days
   - MaxEmployees: 3
   - MaxCompanies: 1
   - Features: All Professional features

3. **Trial expiration**
   - Day 14: Trial expires, show upgrade prompt
   - Day 14-17: Grace period, limited access
   - Day 17+: Access locked until subscription

### Trial Email Notifications

Send emails at:
- **Day 7:** Trial half over reminder
- **Day 13:** Trial expiring tomorrow (24 hours)
- **Day 14:** Trial expired, subscribe now
- **Day 17:** Final warning before lock

---

## License Activation

### Desktop Application Flow

1. **User launches app without license**
   - Show license activation screen
   - Options: Enter license key, Start trial, or Purchase

2. **License key entry**
   ```csharp
   var result = await _licenseService.ActivateLicenseAsync(
       licenseKey: "JERP-XXXX-XXXX-XXXX",
       machineId: _machineIdService.GetMachineId()
   );
   ```

3. **License validation**
   - Check license key exists
   - Verify not expired
   - Check machine binding (1 machine per license)
   - Load enabled features

4. **Success**
   - Store license locally (encrypted)
   - Enable features based on plan
   - Continue to app

### Machine Binding

Each license can be activated on **1 machine**:
- Machine ID generated from hardware (CPU, motherboard, MAC)
- Stored in `License.MachineId`
- To transfer: Deactivate old machine, activate new machine

---

## Feature Gating

### Check Feature Availability

```csharp
// In a service or ViewModel
if (await _featureGuard.RequireFeatureAsync("CertifiedPayroll", "Certified Payroll"))
{
    // Feature is enabled, proceed
    await NavigateToCertifiedPayrollAsync();
}
else
{
    // Feature not available, upgrade prompt shown
    return;
}
```

### Feature Codes

Defined in `AppConstants.Features`:

| Feature Code | Display Name | Minimum Plan |
|-------------|--------------|--------------|
| CoreAccounting | Core Accounting | Starter |
| BasicPayroll | Basic Payroll | Small Business |
| CertifiedPayroll | Certified Payroll | Professional |
| PrevailingWage | Prevailing Wage Tracking | Professional |
| AdvancedJobCosting | Advanced Job Costing | Professional |
| AIABilling | AIA Progress Billing | Professional |
| GPSTimeTracking | GPS Time Tracking | Professional |
| APIAccess | API Access | Professional |
| MultiCompanyConsolidation | Multi-Company Consolidation | Enterprise |
| CustomDevelopment | Custom Development | Ultimate |

### Adding a New Feature

1. Add to `AppConstants.Features`:
```csharp
public const string NewFeature = "NewFeature";
```

2. Add to plan features in `PlanConfiguration`:
```csharp
Features = new[] { "ExistingFeature", "NewFeature" }
```

3. Use in code:
```csharp
if (await _featureGuard.CanAccessFeatureAsync(AppConstants.Features.NewFeature))
{
    // Show feature
}
```

---

## Employee Limits

### Checking Employee Limits

Before adding an employee:

```csharp
var license = await _licenseService.GetLicenseInfoAsync();

if (!license.CanAddEmployee())
{
    // Show upgrade prompt
    await ShowUpgradePromptAsync(
        $"Your {license.Plan} plan allows up to {license.MaxEmployees} employees. " +
        $"You currently have {license.CurrentEmployees} employees. " +
        "Upgrade to add more employees?"
    );
    return false;
}

// Add employee
await _employeeRepository.AddAsync(employee);

// Update count
await _licenseService.UpdateEmployeeCountAsync(license.CurrentEmployees + 1);
```

### Employee Count Tracking

The system automatically tracks employee counts:

```csharp
// Triggered after employee add/remove
await _licenseService.UpdateEmployeeCountAsync(newCount);
```

This creates a record in `EmployeeCountTracking` for historical analysis.

---

## Subscription Management

### Upgrading a Plan

```csharp
var success = await _subscriptionService.UpgradePlanAsync(SubscriptionPlan.Professional);

if (success)
{
    // Redirect to payment
    var checkoutUrl = await _subscriptionService.CreateCheckoutSessionAsync(
        plan: SubscriptionPlan.Professional,
        isAnnual: false
    );
    
    Process.Start(checkoutUrl);
}
```

### Downgrading a Plan

```csharp
var success = await _subscriptionService.DowngradePlanAsync(SubscriptionPlan.SmallBusiness);

// Note: Downgrade may be restricted if:
// - Current employee count exceeds new plan limit
// - Using features not available in lower plan
```

### Canceling a Subscription

```csharp
var success = await _subscriptionService.CancelSubscriptionAsync();

// Note: Access continues until end of current billing period
```

---

## Offline License Validation

### Offline Grace Period

Users can work offline for **7 days** before re-validation required:

```csharp
var license = await _licenseService.GetLicenseInfoAsync();

if (license.LastValidatedAt.HasValue)
{
    var daysSinceValidation = (DateTime.UtcNow - license.LastValidatedAt.Value).TotalDays;
    
    if (daysSinceValidation > 7)
    {
        // Require online validation
        await _licenseService.ValidateLicenseAsync(license.LicenseKey);
    }
}
```

### Forced Online Validation

- On app startup (if online)
- Every 7 days minimum
- On critical operations (e.g., certified payroll)

---

## Security Considerations

### License Key Format

Generate secure license keys:
```
JERP-[PLAN]-[RANDOM]-[CHECKSUM]
Example: JERP-PRO-X7K9-M2P5-A8L3
```

### Encryption

- License keys encrypted at rest
- Machine IDs hashed
- Stripe customer IDs never exposed to client

### Validation

- Server-side validation required
- Client-side caching for offline grace period
- Machine binding prevents sharing

---

## Monitoring & Analytics

### Key Metrics to Track

1. **Active Licenses**
   ```sql
   SELECT Plan, COUNT(*) as Count, SUM(CurrentEmployees) as TotalEmployees
   FROM Licenses
   WHERE Status = 0 -- Active
   GROUP BY Plan
   ```

2. **Trial Conversions**
   ```sql
   SELECT 
       COUNT(CASE WHEN Plan = 0 THEN 1 END) as TrialCount,
       COUNT(CASE WHEN Plan > 0 THEN 1 END) as PaidCount,
       CAST(COUNT(CASE WHEN Plan > 0 THEN 1 END) AS FLOAT) / 
       COUNT(*) * 100 as ConversionRate
   FROM Licenses
   ```

3. **Churn Rate**
   ```sql
   SELECT 
       COUNT(CASE WHEN Status = 2 THEN 1 END) as Cancelled,
       COUNT(*) as Total,
       CAST(COUNT(CASE WHEN Status = 2 THEN 1 END) AS FLOAT) / 
       COUNT(*) * 100 as ChurnRate
   FROM Licenses
   WHERE CreatedAt >= DATEADD(MONTH, -1, GETDATE())
   ```

4. **Revenue (MRR)**
   ```sql
   -- Calculate Monthly Recurring Revenue
   SELECT 
       SUM(CASE 
           WHEN Plan = 1 THEN 79
           WHEN Plan = 2 THEN 149
           WHEN Plan = 3 THEN 299
           WHEN Plan = 4 THEN 599
           WHEN Plan = 5 THEN 999
           ELSE 0
       END) as MRR
   FROM Licenses
   WHERE Status = 0 -- Active
   ```

---

## Troubleshooting

### License Validation Fails

**Problem:** "Invalid license key"

**Solutions:**
1. Check license exists in database
2. Verify license not expired
3. Check machine binding matches
4. Ensure license server accessible

### Employee Limit Exceeded

**Problem:** "Cannot add employee - limit reached"

**Solutions:**
1. Verify current employee count accurate
2. Check for archived employees still counting
3. Offer upgrade to higher plan

### Trial Expired

**Problem:** "Trial period has ended"

**Solutions:**
1. Verify trial expiration date
2. Check grace period not elapsed
3. Prompt for paid subscription

---

## Support

For licensing issues, contact:

- **Email:** ichbincesartobar@yahoo.com
- **Support:** support@jerp3.com
- **Developer:** Julio Cesar Mendez Tobar Jr.

---

© 2026 Julio Cesar Mendez Tobar Jr. All Rights Reserved.
