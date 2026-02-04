# Manual Test Plan for Hash-Chained Audit Log System

## Test 1: Hash Chain Creation

### Steps:
1. Create a new company
2. Create 3 audit log entries for that company
3. Verify each entry has:
   - Sequential SequenceNumber (1, 2, 3)
   - PreviousHash links to previous entry (or "GENESIS" for first)
   - CurrentHash is calculated correctly

### Expected Results:
- Entry 1: SequenceNumber=1, PreviousHash="GENESIS"
- Entry 2: SequenceNumber=2, PreviousHash=Entry1.CurrentHash
- Entry 3: SequenceNumber=3, PreviousHash=Entry2.CurrentHash

## Test 2: Chain Verification (Valid Chain)

### Steps:
1. Use the 3 entries created in Test 1
2. Call VerifyAuditChain endpoint
3. Check response

### Expected Results:
```json
{
  "isValid": true,
  "errorMessage": null,
  "totalEntries": 3,
  "firstInvalidSequence": null
}
```

## Test 3: Chain Verification (Tampered Chain)

### Steps:
1. Manually modify Entry 2's Details field in the database
2. Call VerifyAuditChain endpoint
3. Check response

### Expected Results:
```json
{
  "isValid": false,
  "errorMessage": "Hash mismatch at sequence 2. Entry has been tampered with.",
  "totalEntries": 3,
  "firstInvalidSequence": 2
}
```

## Test 4: CSV Export

### Steps:
1. Call export endpoint for the company
2. Verify CSV contains all entries
3. Check CSV format

### Expected Results:
- CSV file downloads successfully
- Contains header row
- Contains 3 data rows
- All fields present and properly formatted

## Test 5: Payroll Approval Integration

### Steps:
1. Create a pay period
2. Process payroll
3. Approve payroll
4. Check audit log

### Expected Results:
- Audit log contains entry with:
  - action: "payroll_approved"
  - resource: Contains pay period dates
  - details: Contains employee count and total amount

## Test 6: Employee Creation Integration

### Steps:
1. Create a new employee
2. Check audit log

### Expected Results:
- Audit log contains entry with:
  - action: "employee_created"
  - resource: Contains employee number
  - details: Contains employee name and classification

## API Endpoints to Test

### Get Audit Logs
```
GET /api/v1/audit-log?companyId={guid}
```

### Verify Chain
```
POST /api/v1/audit-log/verify?companyId={guid}
```

### Export CSV
```
GET /api/v1/audit-log/export?companyId={guid}
```

## Success Criteria

✅ All 6 tests pass
✅ Hash chain prevents tampering
✅ Verification correctly identifies modified entries
✅ CSV export works
✅ Integration with payroll and employee services works
✅ API endpoints return expected responses
