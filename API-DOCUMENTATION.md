# JERP 2.0 API Documentation

## Overview

The JERP 2.0 API is a comprehensive Enterprise Resource Planning system with payroll and compliance features.

**Base URL:** `http://localhost:5000`  
**API Version:** 2.0.0

## Authentication

All endpoints (except login/register) require JWT Bearer token authentication.

### Login
```
POST /api/v1/auth/login
Content-Type: application/json

{
  "username": "admin",
  "password": "Admin@123"
}

Response:
{
  "success": true,
  "data": {
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
    "refreshToken": "...",
    "expiresIn": 3600
  }
}
```

### Using the Token
```
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

## Endpoints

### Employees
- `GET /api/v1/employees` - List all employees
- `GET /api/v1/employees/{id}` - Get employee by ID
- `POST /api/v1/employees` - Create new employee
- `PUT /api/v1/employees/{id}` - Update employee
- `DELETE /api/v1/employees/{id}` - Delete employee
- `POST /api/v1/employees/{id}/terminate` - Terminate employee

### Timesheets
- `GET /api/v1/timesheets/employee/{employeeId}` - Get timesheets for employee
- `GET /api/v1/timesheets/{id}` - Get timesheet by ID
- `POST /api/v1/timesheets` - Create timesheet
- `PUT /api/v1/timesheets/{id}` - Update timesheet
- `POST /api/v1/timesheets/{id}/submit` - Submit for approval
- `POST /api/v1/timesheets/{id}/approve` - Approve timesheet
- `POST /api/v1/timesheets/{id}/reject` - Reject timesheet

### Payroll
- `GET /api/v1/payroll/periods` - List pay periods
- `GET /api/v1/payroll/periods/{id}` - Get pay period details
- `POST /api/v1/payroll/periods` - Create pay period
- `POST /api/v1/payroll/periods/{id}/process` - Process payroll
- `POST /api/v1/payroll/periods/{id}/approve` - Approve payroll
- `GET /api/v1/payroll/records/{id}` - Get payroll record
- `GET /api/v1/payroll/records/employee/{employeeId}` - Get employee payroll records

### Departments
- `GET /api/v1/departments` - List all departments
- `GET /api/v1/departments/{id}` - Get department by ID
- `POST /api/v1/departments` - Create department
- `PUT /api/v1/departments/{id}` - Update department
- `DELETE /api/v1/departments/{id}` - Delete department

### Reports
- `GET /api/v1/reports/payroll/summary` - Payroll summary report
- `GET /api/v1/reports/employees/hours` - Employee hours report
- `GET /api/v1/reports/compliance/violations` - Compliance violations
- `GET /api/v1/reports/departments/summary` - Department summary

### Dashboard
- `GET /api/v1/dashboard/overview` - Dashboard overview statistics
- `GET /api/v1/dashboard/payroll-metrics` - Payroll metrics
- `GET /api/v1/dashboard/compliance-trend` - Compliance trend
- `GET /api/v1/dashboard/employee-distribution` - Employee distribution
- `GET /api/v1/dashboard/pending-approvals` - Pending approvals

### Compliance
- `GET /api/v1/compliance/violations` - List violations
- `GET /api/v1/compliance/score` - Get compliance score

## Error Responses

```json
{
  "success": false,
  "error": "Error message here"
}
```

## Status Codes

- `200 OK` - Successful request
- `201 Created` - Resource created successfully
- `400 Bad Request` - Invalid request data
- `401 Unauthorized` - Missing or invalid authentication
- `403 Forbidden` - Insufficient permissions
- `404 Not Found` - Resource not found
- `500 Internal Server Error` - Server error

## Interactive Documentation

Visit `http://localhost:5000` for Swagger UI with interactive API documentation.
