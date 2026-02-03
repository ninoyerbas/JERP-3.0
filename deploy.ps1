# JERP 2.0 Deployment Script for Windows

Write-Host "=========================================" -ForegroundColor Cyan
Write-Host "  JERP 2.0 Deployment" -ForegroundColor Cyan
Write-Host "=========================================" -ForegroundColor Cyan

# Load .env file
if (Test-Path .env) {
    Get-Content .env | ForEach-Object {
        if ($_ -match '^\s*([^#][^=]+)=(.*)$') {
            [Environment]::SetEnvironmentVariable($matches[1].Trim(), $matches[2].Trim(), "Process")
        }
    }
}

# Database selection
Write-Host "`nSelect database:" -ForegroundColor Yellow
Write-Host "1. PostgreSQL (default)"
Write-Host "2. MySQL"
Write-Host "3. SQL Server"
$dbChoice = Read-Host "Choice (1-3)"

$profiles = switch ($dbChoice) {
    "2" { "mysql" }
    "3" { "sqlserver" }
    default { "" }
}

if ($profiles) {
    $env:COMPOSE_PROFILES = $profiles
}

# Build and start
Write-Host "`nBuilding Docker images..." -ForegroundColor Yellow
docker-compose build

Write-Host "Starting services..." -ForegroundColor Yellow
docker-compose up -d

# Wait for database
Write-Host "Waiting for database..." -ForegroundColor Yellow
Start-Sleep -Seconds 15

# Run migrations
Write-Host "Running database migrations..." -ForegroundColor Yellow
docker-compose exec -T api dotnet ef database update --project /app/JERP.Infrastructure.dll

Write-Host "`n=========================================" -ForegroundColor Green
Write-Host "  Deployment Complete!" -ForegroundColor Green
Write-Host "=========================================" -ForegroundColor Green
Write-Host "`nAPI: http://localhost:5000"
Write-Host "Swagger: http://localhost:5000/swagger"
Write-Host "Health: http://localhost:5000/health"
Write-Host "`nDefault credentials:"
Write-Host "Username: admin"
Write-Host "Password: Admin@123"
Write-Host "`nView logs: docker-compose logs -f api"
Write-Host "Stop: docker-compose down"
