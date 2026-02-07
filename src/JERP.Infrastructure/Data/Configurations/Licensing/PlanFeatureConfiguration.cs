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
/// Entity configuration for PlanFeature
/// </summary>
public class PlanFeatureConfiguration : IEntityTypeConfiguration<PlanFeature>
{
    public void Configure(EntityTypeBuilder<PlanFeature> builder)
    {
        builder.ToTable("PlanFeatures");
        
        builder.HasKey(f => f.Id);
        
        builder.Property(f => f.LicenseId)
            .IsRequired();
        
        builder.Property(f => f.FeatureCode)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(f => f.FeatureName)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(f => f.IsEnabled)
            .IsRequired()
            .HasDefaultValue(true);
        
        builder.HasIndex(f => new { f.LicenseId, f.FeatureCode });
    }
}
