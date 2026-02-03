using Microsoft.EntityFrameworkCore;

namespace JERP.Infrastructure.Data.Providers;

/// <summary>
/// PostgreSQL database provider factory
/// </summary>
public class PostgreSqlProviderFactory : IDatabaseProviderFactory
{
    public string ProviderName => "PostgreSQL";
    
    public string DefaultPort => "5432";

    public void ConfigureDbContext(DbContextOptionsBuilder builder, string connectionString)
    {
        builder.UseNpgsql(connectionString, options =>
        {
            options.EnableRetryOnFailure(3);
            options.CommandTimeout(30);
            options.MigrationsHistoryTable("__EFMigrationsHistory", "public");
        });
    }

    public bool SupportsFeature(DatabaseFeature feature)
    {
        return feature switch
        {
            DatabaseFeature.JsonSupport => true,
            DatabaseFeature.MaterializedViews => true,
            DatabaseFeature.Sequences => true,
            DatabaseFeature.FullTextSearch => true,
            _ => false
        };
    }

    public string GetConnectionStringTemplate()
        => "Host={host};Port={port};Database={database};Username={username};Password={password};";
}
