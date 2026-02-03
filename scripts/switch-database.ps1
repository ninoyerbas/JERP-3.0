# Switch between database providers

param(
    [Parameter(Mandatory=$true)]
    [ValidateSet("PostgreSQL", "MySQL", "SqlServer")]
    [string]$Provider,
    
    [switch]$UpdateDocker
)

Write-Host "`n=== JERP Database Provider Switcher ===" -ForegroundColor Cyan
Write-Host "Switching to: $Provider`n" -ForegroundColor Yellow

# Update appsettings.json
$configPath = "src/JERP.Api/appsettings.json"
try {
    $config = Get-Content $configPath -Raw | ConvertFrom-Json
    $config.DatabaseSettings.Provider = $Provider
    $config | ConvertTo-Json -Depth 10 | Set-Content $configPath
    Write-Host "✓ Updated appsettings.json" -ForegroundColor Green
}
catch {
    Write-Host "✗ Failed to update appsettings.json" -ForegroundColor Red
    Write-Host $_.Exception.Message -ForegroundColor Red
    exit 1
}

# Update docker-compose if requested
if ($UpdateDocker) {
    Write-Host "`nStopping current containers..." -ForegroundColor Yellow
    docker-compose down
    
    switch ($Provider) {
        "MySQL" {
            Write-Host "Starting MySQL..." -ForegroundColor Yellow
            docker-compose --profile mysql up -d
        }
        "SqlServer" {
            Write-Host "Starting SQL Server..." -ForegroundColor Yellow
            docker-compose --profile sqlserver up -d
        }
        default {
            Write-Host "Starting PostgreSQL..." -ForegroundColor Yellow
            docker-compose up -d
        }
    }
    
    Write-Host "Waiting for database to be ready..." -ForegroundColor Yellow
    Start-Sleep -Seconds 10
    Write-Host "✓ Docker containers updated" -ForegroundColor Green
}

# Run migrations
Write-Host "`nRunning migrations..." -ForegroundColor Yellow
try {
    dotnet ef database update --project src/JERP.Infrastructure --startup-project src/JERP.Api
    Write-Host "✓ Migrations applied" -ForegroundColor Green
}
catch {
    Write-Host "✗ Failed to apply migrations" -ForegroundColor Red
    Write-Host $_.Exception.Message -ForegroundColor Red
    exit 1
}

Write-Host "`n✓ Successfully switched to $Provider!" -ForegroundColor Green
Write-Host "`nNext steps:" -ForegroundColor Cyan
Write-Host "  1. Verify connection string in appsettings.json" -ForegroundColor White
Write-Host "  2. Run 'dotnet run --project src/JERP.Api' to start the API" -ForegroundColor White
Write-Host "  3. Check /health endpoint to verify database connectivity" -ForegroundColor White
