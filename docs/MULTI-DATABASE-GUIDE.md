# Multi-Database Support Guide

JERP 2.0 now supports three database engines out of the box, allowing you to choose the database that best fits your infrastructure and requirements.

## Supported Databases

### PostgreSQL (Default)
- **Best for**: Enterprise deployments, high concurrency, complex queries
- **Default Port**: 5432
- **Key Features**: 
  - JSONB support for flexible data storage
  - Materialized views for performance optimization
  - Excellent ACID compliance
  - Advanced indexing capabilities
  - Native UUID support

### MySQL
- **Best for**: Shared hosting environments, familiar MySQL users, wide compatibility
- **Default Port**: 3306
- **Key Features**:
  - JSON support (MySQL 8.0+)
  - Full-text search capabilities
  - Wide ecosystem support
  - Good performance for read-heavy workloads
  - UTF8MB4 character set support

### SQL Server
- **Best for**: Windows environments, existing SQL Server infrastructure, enterprise features
- **Default Port**: 1433
- **Key Features**:
  - Windows Authentication support
  - Temporal tables for historical data
  - Row-level security
  - Advanced analytics capabilities
  - Enterprise-grade scalability

## Quick Start

### Using PostgreSQL (Default)

PostgreSQL is configured as the default database provider. To use it:

```bash
# Start PostgreSQL container
docker-compose up -d

# Or run locally with your PostgreSQL installation
# Update connection string in appsettings.json
```

### Using MySQL

To switch to MySQL:

```bash
# Start MySQL container
docker-compose --profile mysql up -d

# Update appsettings.json
# Set "Provider": "MySQL" in DatabaseSettings section
```

### Using SQL Server

To switch to SQL Server:

```bash
# Start SQL Server container
docker-compose --profile sqlserver up -d

# Update appsettings.json
# Set "Provider": "SqlServer" in DatabaseSettings section
```

## Configuration

### appsettings.json

Edit `src/JERP.Api/appsettings.json` to configure your database provider:

```json
{
  "DatabaseSettings": {
    "Provider": "PostgreSQL",  // Options: PostgreSQL, MySQL, SqlServer
    "AutoMigrate": true,
    "UseWindowsAuthentication": false  // For SQL Server only
  },
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=jerpdb;Username=postgres;Password=postgres",
    "PostgreSQL": "Host=postgres;Port=5432;Database=jerp_production;Username=jerp_user;Password=YourPassword",
    "MySQL": "Server=mysql;Port=3306;Database=jerp_production;Uid=jerp_user;Pwd=YourPassword;CharSet=utf8mb4;",
    "SqlServer": "Server=sqlserver,1433;Database=jerp_production;User Id=sa;Password=YourPassword;TrustServerCertificate=True;Encrypt=False;"
  }
}
```

### Environment Variables

You can also configure the database using environment variables (see `.env.example`):

```env
DATABASE_PROVIDER=PostgreSQL
POSTGRES_HOST=localhost
POSTGRES_PORT=5432
POSTGRES_DB=jerp_production
POSTGRES_USER=jerp_user
POSTGRES_PASSWORD=YourSecurePassword123!
```

## Switching Databases

### Using the PowerShell Script

The easiest way to switch databases is using the provided script:

```powershell
# Switch to MySQL and update Docker containers
.\scripts\switch-database.ps1 -Provider MySQL -UpdateDocker

# Switch to SQL Server without updating Docker
.\scripts\switch-database.ps1 -Provider SqlServer

# Switch to PostgreSQL
.\scripts\switch-database.ps1 -Provider PostgreSQL -UpdateDocker
```

### Manual Switching

1. **Update Configuration**
   ```json
   {
     "DatabaseSettings": {
       "Provider": "MySQL"  // Change this
     }
   }
   ```

2. **Update Connection String**
   - Ensure the connection string for your chosen provider is correct

3. **Start Database Container** (if using Docker)
   ```bash
   docker-compose --profile mysql up -d
   ```

4. **Run Migrations**
   ```bash
   dotnet ef database update --project src/JERP.Infrastructure --startup-project src/JERP.Api
   ```

## Database Migrations

### Generate Migrations for All Providers

Use the provided script to generate migrations for all three database providers:

```powershell
.\scripts\generate-migrations-all.ps1 AddNewFeature
```

This will:
- Generate migrations for PostgreSQL
- Generate migrations for MySQL
- Generate migrations for SQL Server
- Store each in separate directories under `Data/Migrations/{Provider}`

### Generate Migration for Current Provider

```bash
dotnet ef migrations add MigrationName \
  --project src/JERP.Infrastructure \
  --startup-project src/JERP.Api \
  --context JerpDbContext
```

### Apply Migrations

```bash
# Apply all pending migrations
dotnet ef database update --project src/JERP.Infrastructure --startup-project src/JERP.Api

# Apply specific migration
dotnet ef database update MigrationName --project src/JERP.Infrastructure --startup-project src/JERP.Api

# Rollback to specific migration
dotnet ef database update PreviousMigrationName --project src/JERP.Infrastructure --startup-project src/JERP.Api
```

## Connection Strings

### PostgreSQL

```
Host={host};Port={port};Database={database};Username={username};Password={password};
```

Example:
```
Host=localhost;Port=5432;Database=jerp_production;Username=jerp_user;Password=SecurePass123!
```

### MySQL

```
Server={host};Port={port};Database={database};Uid={username};Pwd={password};CharSet=utf8mb4;
```

Example:
```
Server=localhost;Port=3306;Database=jerp_production;Uid=jerp_user;Pwd=SecurePass123!;CharSet=utf8mb4;
```

### SQL Server

**Standard Authentication:**
```
Server={host},{port};Database={database};User Id={username};Password={password};TrustServerCertificate=True;Encrypt=False;
```

Example:
```
Server=localhost,1433;Database=jerp_production;User Id=sa;Password=SecurePass123!;TrustServerCertificate=True;Encrypt=False;
```

**Windows Authentication:**
```
Server={host};Database={database};Integrated Security=True;TrustServerCertificate=True;Encrypt=False;
```

Example:
```
Server=localhost;Database=jerp_production;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;
```

## Docker Deployment

### PostgreSQL (Default Profile)

```bash
docker-compose up -d
```

Services started:
- postgres (port 5432)
- api (port 5000)

### MySQL Profile

```bash
docker-compose --profile mysql up -d
```

Services started:
- mysql (port 3306)
- api (port 5000)

### SQL Server Profile

```bash
docker-compose --profile sqlserver up -d
```

Services started:
- sqlserver (port 1433)
- api (port 5000)

## Health Checks

JERP automatically configures health checks based on your selected database provider. Access the health check endpoint:

```bash
curl http://localhost:5000/health
```

Expected response:
```json
{
  "status": "Healthy",
  "checks": {
    "database": {
      "status": "Healthy",
      "description": "Database connection is healthy"
    }
  }
}
```

## Troubleshooting

### Connection Issues

**PostgreSQL**
- Verify PostgreSQL is running: `docker ps | grep postgres`
- Check logs: `docker logs jerp-postgres`
- Test connection: `psql -h localhost -U jerp_user -d jerp_production`

**MySQL**
- Verify MySQL is running: `docker ps | grep mysql`
- Check logs: `docker logs jerp-mysql`
- Test connection: `mysql -h localhost -u jerp_user -p jerp_production`

**SQL Server**
- Verify SQL Server is running: `docker ps | grep sqlserver`
- Check logs: `docker logs jerp-sqlserver`
- Test connection: `sqlcmd -S localhost,1433 -U sa -P YourPassword`

### Migration Errors

If migrations fail:

1. **Check provider configuration**
   ```json
   "DatabaseSettings": {
     "Provider": "PostgreSQL"  // Must match your database
   }
   ```

2. **Verify connection string**
   - Ensure credentials are correct
   - Check host/port accessibility
   - Verify database exists

3. **Clean and rebuild**
   ```bash
   dotnet clean
   dotnet build
   dotnet ef database update
   ```

### Performance Optimization

**PostgreSQL**
- Enable query plan caching
- Use JSONB indexes for JSON columns
- Configure connection pooling

**MySQL**
- Optimize buffer pool size
- Use appropriate indexes
- Enable query cache (if applicable)

**SQL Server**
- Configure max server memory
- Use query hints for complex queries
- Enable read committed snapshot isolation

## Best Practices

1. **Use Environment Variables**: Store sensitive connection strings in environment variables, not in appsettings.json

2. **Connection Pooling**: All providers are configured with connection pooling by default

3. **Retry Logic**: Automatic retry on transient failures (configured for all providers)

4. **Migrations**: Always test migrations in a development environment first

5. **Backups**: Implement regular backup strategies regardless of provider

6. **Monitoring**: Use health checks and logging to monitor database connectivity

## Provider-Specific Features

### PostgreSQL Extensions

JERP can leverage PostgreSQL-specific features when using PostgreSQL:
- JSONB for flexible schema
- Full-text search with tsvector
- Array types for collections

### MySQL Considerations

When using MySQL:
- String columns have a default max length of 255
- UTF8MB4 is used for full Unicode support
- JSON columns use MySQL's native JSON type

### SQL Server Features

When using SQL Server:
- Windows Authentication is supported
- Temporal tables can be enabled for audit trails
- Row-level security for multi-tenant scenarios

## Security Notes

1. **Never commit connection strings with real credentials**
2. **Use strong passwords** (minimum 12 characters, mixed case, numbers, symbols)
3. **Enable SSL/TLS** for production databases
4. **Restrict network access** using firewalls
5. **Use least privilege** for database users
6. **Regular security updates** for database engines

## Additional Resources

- [PostgreSQL Documentation](https://www.postgresql.org/docs/)
- [MySQL Documentation](https://dev.mysql.com/doc/)
- [SQL Server Documentation](https://docs.microsoft.com/en-us/sql/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

## Support

For issues or questions:
1. Check this guide and troubleshooting section
2. Review application logs in `logs/` directory
3. Check database logs using `docker logs` commands
4. Consult the provider's documentation
5. Open an issue in the GitHub repository
