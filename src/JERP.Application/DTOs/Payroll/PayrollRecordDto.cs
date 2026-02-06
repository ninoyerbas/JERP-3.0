/*
 * JERP 3.0 - Payroll & ERP System
 * Copyright (c) 2026 ninoyerbas. All Rights Reserved.
 * 
 * PROPRIETARY AND CONFIDENTIAL
 */

namespace JERP.Application.DTOs.Payroll;

/// <summary>
/// Payroll record data transfer object
/// </summary>
public class PayrollRecordDto
{
    public Guid Id { get; set; }
    public Guid PayPeriodId { get; set; }
    public Guid EmployeeId { get; set; }
    public required string EmployeeNumber { get; set; }
    public required string EmployeeName { get; set; }
    public decimal RegularHours { get; set; }
    public decimal OvertimeHours { get; set; }
    public decimal RegularPay { get; set; }
    public decimal OvertimePay { get; set; }
    public decimal GrossPay { get; set; }
    public decimal FederalTax { get; set; }
    public decimal StateTax { get; set; }
    public decimal SocialSecurityTax { get; set; }
    public decimal MedicareTax { get; set; }
    public decimal TotalTaxes { get; set; }
    public decimal TotalDeductions { get; set; }
    public decimal NetPay { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? PaymentMethod { get; set; }
    public string? PaymentReference { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
