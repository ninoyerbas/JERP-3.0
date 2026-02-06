/*
 * JERP 3.0 - Payroll & ERP System
 * Copyright (c) 2026 ninoyerbas. All Rights Reserved.
 * 
 * PROPRIETARY AND CONFIDENTIAL
 * 
 * This source code is the confidential and proprietary information of ninoyerbas.
 * Unauthorized copying, modification, distribution, or use is strictly prohibited.
 * 
 * For licensing inquiries: licensing@jerp.io
 */

using JERP.Core.Enums;

namespace JERP.Application.DTOs.Finance;

/// <summary>
/// Bill (Accounts Payable) data transfer object
/// </summary>
public class BillDto
{
    public Guid Id { get; set; }
    public Guid CompanyId { get; set; }
    public Guid VendorId { get; set; }
    public string VendorName { get; set; } = string.Empty;
    public string VendorNumber { get; set; } = string.Empty;
    public string BillNumber { get; set; } = string.Empty;
    public string VendorInvoiceNumber { get; set; } = string.Empty;
    public DateTime BillDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Subtotal { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal AmountPaid { get; set; }
    public BillStatus Status { get; set; }
    public bool IsPaid { get; set; }
    public DateTime? PaymentDate { get; set; }
    public Guid? JournalEntryId { get; set; }
    public string? Notes { get; set; }
    public List<BillLineItemDto> LineItems { get; set; } = new();
    public List<BillPaymentDto> Payments { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

/// <summary>
/// Bill line item data transfer object
/// </summary>
public class BillLineItemDto
{
    public Guid Id { get; set; }
    public Guid BillId { get; set; }
    public Guid AccountId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public string AccountName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Amount { get; set; }
    public bool IsCOGS { get; set; }
}

/// <summary>
/// Bill payment data transfer object
/// </summary>
public class BillPaymentDto
{
    public Guid Id { get; set; }
    public Guid CompanyId { get; set; }
    public Guid BillId { get; set; }
    public string PaymentNumber { get; set; } = string.Empty;
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string? ReferenceNumber { get; set; }
    public Guid? JournalEntryId { get; set; }
    public string? Notes { get; set; }
}

/// <summary>
/// Request to create a new bill
/// </summary>
public class CreateBillDto
{
    public Guid VendorId { get; set; }
    public string BillNumber { get; set; } = string.Empty;
    public string VendorInvoiceNumber { get; set; } = string.Empty;
    public DateTime BillDate { get; set; }
    public DateTime DueDate { get; set; }
    public string? Notes { get; set; }
    public List<CreateBillLineDto> LineItems { get; set; } = new();
}

/// <summary>
/// Request to create a bill line item
/// </summary>
public class CreateBillLineDto
{
    public Guid AccountId { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
