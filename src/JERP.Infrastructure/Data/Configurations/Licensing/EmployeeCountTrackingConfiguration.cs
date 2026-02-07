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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JERP.Core.Entities.Licensing;

namespace JERP.Infrastructure.Data.Configurations.Licensing;

/// <summary>
/// Entity configuration for EmployeeCountTracking
/// </summary>
public class EmployeeCountTrackingConfiguration : IEntityTypeConfiguration<EmployeeCountTracking>
{
    public void Configure(EntityTypeBuilder<EmployeeCountTracking> builder)
    {
        builder.ToTable("EmployeeCountTracking");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.LicenseId)
            .IsRequired();
        
        builder.Property(e => e.EmployeeCount)
            .IsRequired();
        
        builder.Property(e => e.RecordedAt)
            .IsRequired();
        
        builder.HasIndex(e => new { e.LicenseId, e.RecordedAt });
    }
}
