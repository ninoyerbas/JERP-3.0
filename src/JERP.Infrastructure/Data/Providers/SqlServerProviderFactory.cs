using Microsoft.EntityFrameworkCore;

namespace JERP.Infrastructure.Data.Providers;

/// <summary>
/// SQL Server database provider factory
/// </summary>
public class SqlServerProviderFactory : IDatabaseProviderFactory
{
    public string ProviderName => "SQL Server";
    
    public string DefaultPort => "1433";

    public void ConfigureDbContext(DbContextOptionsBuilder builder, string connectionString)
    {
        builder.UseSqlServer(connectionString, options =>
        {
            options.EnableRetryOnFailure(3);
            options.CommandTimeout(30);
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            options.MigrationsHistoryTable("__EFMigrationsHistory");
        });
    }

    public bool SupportsFeature(DatabaseFeature feature)
    {
        return feature switch
        {
            DatabaseFeature.JsonSupport => true,
            DatabaseFeature.FullTextSearch => true,
            DatabaseFeature.RowLevelSecurity => true,
            DatabaseFeature.TemporalTables => true,
            DatabaseFeature.WindowsAuthentication => true,
            _ => false
        };
    }

    public string GetConnectionStringTemplate()
        => "Server={host},{port};Database={database};User Id={username};Password={password};TrustServerCertificate=True;Encrypt=False;";

    /// <summary>
    /// Gets a connection string configured for Windows Authentication
    /// </summary>
    public string GetWindowsAuthConnectionString(string host, string database)
        => $"Server={host};Database={database};Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
}
