using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace JERP.Infrastructure.Data.Providers;

/// <summary>
/// MySQL database provider factory
/// </summary>
public class MySqlProviderFactory : IDatabaseProviderFactory
{
    public string ProviderName => "MySQL";
    
    public string DefaultPort => "3306";

    public void ConfigureDbContext(DbContextOptionsBuilder builder, string connectionString)
    {
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        builder.UseMySql(connectionString, serverVersion, options =>
        {
            options.EnableRetryOnFailure(3);
            options.CommandTimeout(30);
            options.MigrationsHistoryTable("__EFMigrationsHistory");
        });
    }

    public bool SupportsFeature(DatabaseFeature feature)
    {
        return feature switch
        {
            DatabaseFeature.JsonSupport => true,
            DatabaseFeature.FullTextSearch => true,
            _ => false
        };
    }

    public string GetConnectionStringTemplate()
        => "Server={host};Port={port};Database={database};Uid={username};Pwd={password};CharSet=utf8mb4;";
}
