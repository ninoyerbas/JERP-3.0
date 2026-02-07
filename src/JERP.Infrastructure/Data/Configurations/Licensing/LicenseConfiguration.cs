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
/// Entity configuration for License
/// </summary>
public class LicenseConfiguration : IEntityTypeConfiguration<License>
{
    public void Configure(EntityTypeBuilder<License> builder)
    {
        builder.ToTable("Licenses");
        
        builder.HasKey(l => l.Id);
        
        builder.Property(l => l.LicenseKey)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.HasIndex(l => l.LicenseKey)
            .IsUnique();
        
        builder.Property(l => l.CustomerName)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(l => l.CustomerEmail)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(l => l.Plan)
            .IsRequired();
        
        builder.Property(l => l.IssueDate)
            .IsRequired();
        
        builder.Property(l => l.ExpirationDate)
            .IsRequired();
        
        builder.Property(l => l.MaxEmployees)
            .IsRequired();
        
        builder.Property(l => l.CurrentEmployees)
            .IsRequired()
            .HasDefaultValue(0);
        
        builder.Property(l => l.MaxCompanies)
            .IsRequired();
        
        builder.Property(l => l.CurrentCompanies)
            .IsRequired()
            .HasDefaultValue(0);
        
        builder.Property(l => l.MachineId)
            .HasMaxLength(200);
        
        builder.Property(l => l.Status)
            .IsRequired();
        
        builder.Property(l => l.StripeCustomerId)
            .HasMaxLength(100);
        
        builder.Property(l => l.StripeSubscriptionId)
            .HasMaxLength(100);
        
        builder.Property(l => l.IsAnnualBilling)
            .IsRequired()
            .HasDefaultValue(false);
        
        builder.Property(l => l.LastValidatedAt);
        
        // Relationships
        builder.HasMany(l => l.EnabledFeatures)
            .WithOne(f => f.License)
            .HasForeignKey(f => f.LicenseId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(l => l.SubscriptionHistory)
            .WithOne(h => h.License)
            .HasForeignKey(h => h.LicenseId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(l => l.EmployeeCountHistory)
            .WithOne(e => e.License)
            .HasForeignKey(e => e.LicenseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
