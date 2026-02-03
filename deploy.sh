#!/bin/bash
# JERP 2.0 Deployment Script

set -e

echo "========================================="
echo "  JERP 2.0 Deployment"
echo "========================================="

# Load environment variables
if [ -f .env ]; then
    export $(cat .env | grep -v '^#' | xargs)
fi

# Database selection
echo ""
echo "Select database:"
echo "1. PostgreSQL (default)"
echo "2. MySQL"
echo "3. SQL Server"
read -p "Choice (1-3): " db_choice

case $db_choice in
    2)
        export COMPOSE_PROFILES="mysql"
        ;;
    3)
        export COMPOSE_PROFILES="sqlserver"
        ;;
    *)
        export COMPOSE_PROFILES=""
        ;;
esac

# Build and start
echo ""
echo "Building Docker images..."
docker-compose build

echo "Starting services..."
docker-compose up -d

# Wait for database
echo "Waiting for database to be ready..."
sleep 15

# Run migrations
echo "Running database migrations..."
docker-compose exec -T api dotnet ef database update --project /app/JERP.Infrastructure.dll || true

echo ""
echo "========================================="
echo "  Deployment Complete!"
echo "========================================="
echo ""
echo "API: http://localhost:5000"
echo "Swagger: http://localhost:5000/swagger"
echo "Health: http://localhost:5000/health"
echo ""
echo "Default credentials:"
echo "Username: admin"
echo "Password: Admin@123"
echo ""
echo "View logs: docker-compose logs -f api"
echo "Stop: docker-compose down"
