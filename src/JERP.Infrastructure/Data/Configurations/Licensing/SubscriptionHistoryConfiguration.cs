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
/// Entity configuration for SubscriptionHistory
/// </summary>
public class SubscriptionHistoryConfiguration : IEntityTypeConfiguration<SubscriptionHistory>
{
    public void Configure(EntityTypeBuilder<SubscriptionHistory> builder)
    {
        builder.ToTable("SubscriptionHistory");
        
        builder.HasKey(h => h.Id);
        
        builder.Property(h => h.LicenseId)
            .IsRequired();
        
        builder.Property(h => h.Plan)
            .IsRequired();
        
        builder.Property(h => h.Action)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(h => h.Details)
            .HasMaxLength(500);
        
        builder.Property(h => h.OccurredAt)
            .IsRequired();
        
        builder.HasIndex(h => new { h.LicenseId, h.OccurredAt });
    }
}
