# FASB ASC Structure Reference

## Overview

JERP 3.0 uses the **FASB ASC (Financial Accounting Standards Board Accounting Standards Codification)** structure for categorizing accounts instead of traditional account subtypes. This provides better alignment with GAAP compliance and professional accounting standards.

## What Changed

### Before (Deprecated)
- Accounts used `AccountSubType` enum (Cash, AccountsReceivable, Inventory, etc.)
- Simple categorization but limited flexibility
- Not aligned with professional accounting standards

### After (Current)
- All accounts **REQUIRE** FASB Topic and Subtopic references
- Each account has:
  - `FASBTopicId` (required) - Links to a FASB Topic
  - `FASBSubtopicId` (required) - Links to a FASB Subtopic
  - `FASBReference` (required) - Full reference string (e.g., "ASC 606-10")
- Aligned with GAAP and professional accounting standards

## FASB Category Structure

The FASB ASC is organized into 8 main categories:

### 1. **Presentation Topics (200s)**
Topics related to financial statement presentation and format
- 205: Presentation of Financial Statements
- 210: Balance Sheet
- 220: Income Statement
- 225: Income Statement—Discontinued Operations
- 230: Statement of Cash Flows
- 235: Notes to Financial Statements
- 250: Accounting Changes and Error Corrections
- 260: Earnings Per Share
- 270: Interim Reporting
- 272: Limited Liability Entities
- 273: Corporate Joint Ventures
- 274: Personal Financial Statements
- 280: Segment Reporting

### 2. **Assets (300s)**
Topics related to asset recognition, measurement, and disclosure
- 305: Cash and Cash Equivalents
- 310: Receivables
- 320: Investments—Debt Securities (SUPERSEDED by ASC 321 and ASC 326)
- 321: Investments—Equity Securities
- 323: Investments—Equity Method and Joint Ventures
- 325: Investments—Other
- 326: Financial Instruments—Credit Losses
- 330: Inventory
- 340: Other Assets and Deferred Costs
- 350: Intangibles—Goodwill and Other
- 360: Property, Plant, and Equipment

### 3. **Liabilities (400s)**
Topics related to liability recognition, measurement, and disclosure
- 405: Liabilities
- 410: Asset Retirement and Environmental Obligations
- 420: Exit or Disposal Cost Obligations
- 430: Deferred Revenue (SUPERSEDED by ASC 606)
- 440: Commitments
- 450: Contingencies
- 460: Guarantees
- 470: Debt

### 4. **Equity (500s)**
Topics related to equity transactions and reporting
- 505: Equity

### 5. **Revenue (600s)**
Topics related to revenue recognition and measurement
- 605: Revenue Recognition (SUPERSEDED by ASC 606)
- 606: Revenue from Contracts with Customers
- 610: Other Income

### 6. **Expenses (700s)**
Topics related to expense recognition and measurement
- 705: Cost of Sales and Services
- 710: Compensation—General
- 712: Compensation—Nonretirement Postemployment Benefits
- 715: Compensation—Retirement Benefits
- 718: Compensation—Stock Compensation
- 720: Other Expenses
- 730: Research and Development

### 7. **Broad Transactions (800s)**
Cross-cutting accounting topics that apply across industries
- 805: Business Combinations
- 808: Collaborative Arrangements
- 810: Consolidation
- 815: Derivatives and Hedging
- 820: Fair Value Measurement
- 825: Financial Instruments
- 830: Foreign Currency Matters
- 835: Interest
- 840: Leases (SUPERSEDED by ASC 842)
- 842: Leases
- 845: Nonmonetary Transactions
- 848: Reference Rate Reform
- 850: Related Party Disclosures
- 852: Reorganizations
- 860: Transfers and Servicing

### 8. **Industry Topics (900s)**
Industry-specific accounting guidance
- 905: Agriculture
- 908: Airlines
- 912: Contractors—Federal Government
- 920: Entertainment—Broadcasters
- 922: Entertainment—Cable Television
- 924: Entertainment—Casinos
- 926: Entertainment—Films
- 928: Entertainment—Music
- 930: Extractive Activities—Mining
- 932: Extractive Activities—Oil and Gas
- 940: Financial Services—Brokers and Dealers
- 942: Financial Services—Depository and Lending
- 944: Financial Services—Insurance
- 946: Financial Services—Investment Companies
- 948: Financial Services—Mortgage Banking
- 950: Financial Services—Title Plant
- 952: Franchisors
- 954: Health Care Entities
- 958: Not-for-Profit Entities
- 960: Plan Accounting—Defined Benefit Pension Plans
- 962: Plan Accounting—Defined Contribution Pension Plans
- 965: Plan Accounting—Health and Welfare Benefit Plans
- 970: Real Estate—General
- 972: Real Estate—Common Interest Realty Associations
- 974: Real Estate—Real Estate Investment Trusts
- 976: Real Estate—Retail Land (SUPERSEDED by ASC 606)
- 978: Real Estate—Time-Sharing Activities
- 980: Regulated Operations
- 985: Software

## Common Account Mappings

### Assets
| Traditional Account Type | FASB Reference | Description |
|-------------------------|---------------|-------------|
| Cash | ASC 305-10 | Cash and Cash Equivalents - Overall |
| Accounts Receivable | ASC 310-10 | Receivables - Overall |
| Inventory | ASC 330-10 | Inventory - Overall |
| Fixed Assets | ASC 360-10 | Property, Plant, and Equipment - Overall |
| Intangible Assets | ASC 350-10 | Intangibles—Goodwill and Other - Overall |

### Liabilities
| Traditional Account Type | FASB Reference | Description |
|-------------------------|---------------|-------------|
| Accounts Payable | ASC 405-10 | Liabilities - Overall |
| Short-term Debt | ASC 470-10 | Debt - Overall |
| Long-term Debt | ASC 470-10 | Debt - Overall |
| Lease Liabilities | ASC 842-20 | Leases - Lessee |

### Equity
| Traditional Account Type | FASB Reference | Description |
|-------------------------|---------------|-------------|
| Common Stock | ASC 505-10 | Equity - Overall |
| Retained Earnings | ASC 505-10 | Equity - Overall |
| Distributions | ASC 505-10 | Equity - Overall |

### Revenue
| Traditional Account Type | FASB Reference | Description |
|-------------------------|---------------|-------------|
| Product Sales | ASC 606-10 | Revenue from Contracts with Customers - Overall |
| Service Revenue | ASC 606-10 | Revenue from Contracts with Customers - Overall |
| Other Income | ASC 610-10 | Other Income - Overall |

### Expenses
| Traditional Account Type | FASB Reference | Description |
|-------------------------|---------------|-------------|
| Cost of Goods Sold | ASC 705-10 | Cost of Sales and Services - Overall |
| Payroll Expense | ASC 710-10 | Compensation—General - Overall |
| Rent Expense | ASC 842-20 | Leases - Lessee |
| Research & Development | ASC 730-10 | Research and Development - Overall |
| Other Operating Expenses | ASC 720-10 | Other Expenses - Overall |

## Cannabis 280E Compliance

JERP 3.0 maintains full support for IRC Section 280E compliance for cannabis businesses:

- **IsCOGS**: Flag accounts that represent Cost of Goods Sold (280E deductible)
- **IsNonDeductible**: Flag accounts for non-deductible operating expenses
- **TaxCategory**: Custom tax categories for specialized reporting

These fields work **in conjunction** with FASB references to provide both GAAP compliance and 280E tracking.

### Example: Cannabis COGS Account
```json
{
  "accountNumber": "5000",
  "accountName": "Cannabis Product Cost",
  "type": "Expense",
  "fasbTopicId": "<guid-for-ASC-705>",
  "fasbSubtopicId": "<guid-for-ASC-705-10>",
  "fasbReference": "ASC 705-10",
  "isCOGS": true,
  "isNonDeductible": false,
  "taxCategory": "280E Deductible COGS"
}
```

### Example: Non-Deductible Operating Expense
```json
{
  "accountNumber": "7000",
  "accountName": "Marketing & Advertising",
  "type": "Expense",
  "fasbTopicId": "<guid-for-ASC-720>",
  "fasbSubtopicId": "<guid-for-ASC-720-10>",
  "fasbReference": "ASC 720-10",
  "isCOGS": false,
  "isNonDeductible": true,
  "taxCategory": "280E Non-Deductible"
}
```

## API Endpoints

### FASB Lookup

**Get all FASB Topics**
```
GET /api/v1/finance/fasb/topics
GET /api/v1/finance/fasb/topics?category=Expenses
```

**Get a specific FASB Topic with subtopics**
```
GET /api/v1/finance/fasb/topics/{topicId}
```

**Get subtopics for a topic**
```
GET /api/v1/finance/fasb/topics/{topicId}/subtopics
```

**Search FASB references**
```
GET /api/v1/finance/fasb/search?query=receivables
```

### Account Management

**Create Account (requires FASB references)**
```json
POST /api/v1/finance/accounts
{
  "companyId": "...",
  "accountNumber": "1100",
  "accountName": "Accounts Receivable - Trade",
  "type": "Asset",
  "fasbTopicId": "...",
  "fasbSubtopicId": "...",
  "fasbReference": "ASC 310-10",
  "isCOGS": false,
  "isNonDeductible": false
}
```

## Migration Notes

### Automatic Changes
The database migration `ReplaceCOAWithFASBStructure` automatically:
1. Adds `SupersededBy` field to FASBTopics table
2. Adds `FullReference` field to FASBSubtopics table
3. Makes `FASBTopicId`, `FASBSubtopicId`, and `FASBReference` required in Accounts table
4. Removes `SubType` column from Accounts table
5. **Deletes all existing accounts** (clean slate approach)
6. Re-seeds all FASB topics and subtopics with complete data

### Important Warning
**All existing accounts will be deleted during migration.** This is by design to ensure clean transition to the FASB structure. After migration:
- All companies will need to recreate their chart of accounts with proper FASB references
- Use the FASB lookup endpoints to find appropriate topics/subtopics
- Refer to the common mappings table above for guidance

### Deprecated Code
- `AccountSubType` enum - marked as obsolete
- `ChartOfAccountsSeedService` - throws exception, must use FASB-based account creation

## Best Practices

1. **Always use FASB search** - Look up the appropriate FASB topic/subtopic before creating accounts
2. **Consistent references** - Use the same FASB reference for similar accounts across companies
3. **Document choices** - Use the account description field to explain non-obvious FASB mappings
4. **Review superseded topics** - Avoid using superseded FASB topics (e.g., ASC 605, ASC 840)
5. **Cannabis compliance** - Always set IsCOGS and IsNonDeductible appropriately for cannabis businesses

## Support

For questions about FASB ASC classifications or account setup, consult:
- FASB website: https://www.fasb.org/
- FASB Codification (subscription required)
- Your company's CPA or accounting professional

## See Also

- [Finance Module Implementation](FINANCE-MODULE-IMPLEMENTATION.md)
- [API Documentation](API-DOCUMENTATION.md)
- FASB.org official documentation
