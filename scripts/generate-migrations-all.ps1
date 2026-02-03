# Generate migrations for all database providers

param(
    [Parameter(Mandatory=$true)]
    [string]$MigrationName
)

$providers = @("PostgreSQL", "MySQL", "SqlServer")

Write-Host "`n=== JERP Multi-Database Migration Generator ===" -ForegroundColor Cyan
Write-Host "Migration Name: $MigrationName`n" -ForegroundColor Yellow

foreach ($provider in $providers) {
    Write-Host "Generating migration for $provider..." -ForegroundColor Yellow
    
    # Update appsettings temporarily
    $configPath = "src/JERP.Api/appsettings.json"
    $config = Get-Content $configPath -Raw | ConvertFrom-Json
    $originalProvider = $config.DatabaseSettings.Provider
    $config.DatabaseSettings.Provider = $provider
    $config | ConvertTo-Json -Depth 10 | Set-Content $configPath
    
    # Generate migration
    try {
        dotnet ef migrations add $MigrationName `
            --project src/JERP.Infrastructure `
            --startup-project src/JERP.Api `
            --output-dir "Data/Migrations/$provider" `
            --context JerpDbContext
        
        Write-Host "✓ Created migration for $provider" -ForegroundColor Green
    }
    catch {
        Write-Host "✗ Failed to create migration for $provider" -ForegroundColor Red
        Write-Host $_.Exception.Message -ForegroundColor Red
    }
    
    # Restore original config
    $config.DatabaseSettings.Provider = $originalProvider
    $config | ConvertTo-Json -Depth 10 | Set-Content $configPath
}

Write-Host "`n✓ All migrations generated!" -ForegroundColor Green
Write-Host "Note: Review and test each migration before applying to production." -ForegroundColor Yellow
