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

using System.Security.Cryptography;
using System.Text;
using JERP.Core.Entities;
using JERP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace JERP.Application.Services.AuditLog;

/// <summary>
/// Service for managing hash-chained audit log entries with blockchain-style integrity
/// </summary>
public class AuditLogService : IAuditLogService
{
    private readonly JerpDbContext _context;
    private readonly ILogger<AuditLogService> _logger;
    private const string GenesisHash = "GENESIS";

    public AuditLogService(JerpDbContext context, ILogger<AuditLogService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Logs an action to the audit trail with hash-chain integrity
    /// NOTE: This method uses database-level unique constraint on (CompanyId, SequenceNumber)
    /// to prevent race conditions. If concurrent requests try to insert the same sequence number,
    /// the database will reject the duplicate and throw an exception.
    /// </summary>
    public async Task<Core.Entities.AuditLog> LogActionAsync(
        Guid companyId,
        Guid userId,
        string userEmail,
        string action,
        string resource,
        string details,
        string ipAddress)
    {
        // Get the last audit entry for this company to continue the chain
        // Race condition is mitigated by unique constraint on (CompanyId, SequenceNumber) in DB
        var lastEntry = await _context.AuditLogs
            .Where(al => al.CompanyId == companyId)
            .OrderByDescending(al => al.SequenceNumber)
            .FirstOrDefaultAsync();

        var sequenceNumber = lastEntry != null ? lastEntry.SequenceNumber + 1 : 1;
        var previousHash = lastEntry?.CurrentHash ?? GenesisHash;

        var entry = new Core.Entities.AuditLog
        {
            CompanyId = companyId,
            Timestamp = DateTime.UtcNow,
            UserId = userId,
            UserEmail = userEmail,
            Action = action,
            Resource = resource,
            Details = details,
            IpAddress = ipAddress,
            PreviousHash = previousHash,
            SequenceNumber = sequenceNumber
        };

        // Calculate the hash for this entry
        entry.CurrentHash = CalculateHash(entry);

        try
        {
            await _context.AuditLogs.AddAsync(entry);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (ex.InnerException?.Message?.Contains("IX_AuditLogs_CompanyId_SequenceNumber") == true)
        {
            // Retry if there was a race condition
            _logger.LogWarning("Sequence number collision detected for CompanyId={CompanyId}, retrying...", companyId);
            return await LogActionAsync(companyId, userId, userEmail, action, resource, details, ipAddress);
        }

        _logger.LogInformation(
            "Audit log entry created: CompanyId={CompanyId}, Seq={Seq}, Action={Action}, User={UserEmail}",
            companyId, sequenceNumber, action, userEmail);

        return entry;
    }

    /// <summary>
    /// Verifies the integrity of the entire audit chain for a company
    /// </summary>
    public async Task<(bool IsValid, string? ErrorMessage, int TotalEntries, int? FirstInvalidSequence)> VerifyAuditChainAsync(Guid companyId)
    {
        var entries = await _context.AuditLogs
            .Where(al => al.CompanyId == companyId)
            .OrderBy(al => al.SequenceNumber)
            .ToListAsync();

        var totalEntries = entries.Count;

        if (totalEntries == 0)
        {
            return (true, null, 0, null);
        }

        // Verify first entry links to genesis
        var firstEntry = entries[0];
        if (firstEntry.PreviousHash != GenesisHash)
        {
            return (false, $"First entry does not link to GENESIS. Expected '{GenesisHash}', got '{firstEntry.PreviousHash}'",
                totalEntries, (int)firstEntry.SequenceNumber);
        }

        // Verify each entry's hash
        for (int i = 0; i < entries.Count; i++)
        {
            var entry = entries[i];
            var expectedHash = CalculateHash(entry);

            if (entry.CurrentHash != expectedHash)
            {
                return (false, $"Hash mismatch at sequence {entry.SequenceNumber}. Entry has been tampered with.",
                    totalEntries, (int)entry.SequenceNumber);
            }

            // Verify chain linkage (except for first entry)
            if (i > 0)
            {
                var previousEntry = entries[i - 1];
                if (entry.PreviousHash != previousEntry.CurrentHash)
                {
                    return (false, $"Chain broken at sequence {entry.SequenceNumber}. PreviousHash does not match previous entry's CurrentHash.",
                        totalEntries, (int)entry.SequenceNumber);
                }
            }
        }

        _logger.LogInformation("Audit chain verified successfully for CompanyId={CompanyId}. Total entries: {Count}", 
            companyId, totalEntries);

        return (true, null, totalEntries, null);
    }

    /// <summary>
    /// Gets audit log entries for a company with optional filtering
    /// </summary>
    public async Task<IEnumerable<Core.Entities.AuditLog>> GetAuditLogsAsync(
        Guid companyId,
        DateTime? startDate = null,
        DateTime? endDate = null,
        string? action = null,
        int? limit = null)
    {
        var query = _context.AuditLogs
            .Where(al => al.CompanyId == companyId);

        if (startDate.HasValue)
        {
            query = query.Where(al => al.Timestamp >= startDate.Value);
        }

        if (endDate.HasValue)
        {
            query = query.Where(al => al.Timestamp <= endDate.Value);
        }

        if (!string.IsNullOrEmpty(action))
        {
            query = query.Where(al => al.Action == action);
        }

        query = query.OrderByDescending(al => al.Timestamp);

        if (limit.HasValue)
        {
            query = query.Take(limit.Value);
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Exports audit log to CSV format
    /// </summary>
    public async Task<byte[]> ExportToCsvAsync(Guid companyId, DateTime? startDate = null, DateTime? endDate = null)
    {
        var entries = await GetAuditLogsAsync(companyId, startDate, endDate);

        var csv = new StringBuilder();
        
        // CSV Header
        csv.AppendLine("Sequence,Timestamp,User Email,Action,Resource,Details,IP Address,Previous Hash,Current Hash");

        // CSV Rows
        foreach (var entry in entries.OrderBy(e => e.SequenceNumber))
        {
            csv.AppendLine($"{entry.SequenceNumber}," +
                          $"\"{entry.Timestamp:yyyy-MM-dd HH:mm:ss}\"," +
                          $"\"{EscapeCsv(entry.UserEmail)}\"," +
                          $"\"{EscapeCsv(entry.Action)}\"," +
                          $"\"{EscapeCsv(entry.Resource)}\"," +
                          $"\"{EscapeCsv(entry.Details)}\"," +
                          $"\"{EscapeCsv(entry.IpAddress)}\"," +
                          $"\"{entry.PreviousHash}\"," +
                          $"\"{entry.CurrentHash}\"");
        }

        return Encoding.UTF8.GetBytes(csv.ToString());
    }

    /// <summary>
    /// Calculates SHA256 hash for an audit log entry
    /// </summary>
    private string CalculateHash(Core.Entities.AuditLog entry)
    {
        var data = $"{entry.CompanyId}|{entry.Timestamp:O}|{entry.UserId}|{entry.UserEmail}|" +
                   $"{entry.Action}|{entry.Resource}|{entry.Details}|{entry.IpAddress}|" +
                   $"{entry.SequenceNumber}|{entry.PreviousHash}";

        using var sha256 = SHA256.Create();
        var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
        return Convert.ToHexString(hashBytes);
    }

    /// <summary>
    /// Escapes special characters for CSV format and prevents CSV injection
    /// </summary>
    private string EscapeCsv(string value)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;

        // Prevent CSV injection by sanitizing formula characters
        if (value.Length > 0)
        {
            var firstChar = value[0];
            if (firstChar == '=' || firstChar == '+' || firstChar == '-' || firstChar == '@' || firstChar == '\t' || firstChar == '\r')
            {
                // Prepend with single quote to prevent formula interpretation
                value = "'" + value;
            }
        }

        // Escape double quotes by doubling them
        return value.Replace("\"", "\"\"");
    }
}
