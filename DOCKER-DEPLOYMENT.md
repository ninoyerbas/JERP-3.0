# JERP 2.0 Docker Deployment Guide

## Prerequisites

- Docker 20.10+ and Docker Compose 2.0+
- 4GB RAM minimum, 8GB recommended
- 20GB disk space

## Quick Start

1. **Clone the repository**
```bash
git clone https://github.com/yourusername/JERP-3.0.git
cd JERP-3.0
```

2. **Configure environment**
```bash
cp .env.example .env
# Edit .env with your passwords and secrets
```

3. **Deploy**

**Linux/Mac:**
```bash
chmod +x deploy.sh
./deploy.sh
```

**Windows:**
```powershell
.\deploy.ps1
```

4. **Access the API**
- API: http://localhost:5000
- Swagger: http://localhost:5000/swagger
- Health: http://localhost:5000/health

## Database Options

### PostgreSQL (Default)
```bash
docker-compose up -d
```

### MySQL
```bash
COMPOSE_PROFILES=mysql docker-compose up -d
```

### SQL Server
```bash
COMPOSE_PROFILES=sqlserver docker-compose up -d
```

## Environment Variables

Edit `.env` file:

```bash
# Database passwords
POSTGRES_PASSWORD=YourSecurePassword123!
MYSQL_PASSWORD=YourSecurePassword123!
SQLSERVER_PASSWORD=YourStrong!Passw0rd

# JWT secret (minimum 32 characters)
JWT_SECRET_KEY=YourSuperSecretKeyForJWTTokenGeneration...

# Environment
ASPNETCORE_ENVIRONMENT=Production
```

## Development Mode

```bash
docker-compose -f docker-compose.yml -f docker-compose.dev.yml up
```

This enables:
- Hot reload
- Development database
- Detailed logging
- Source code mounting

## Common Commands

**View logs:**
```bash
docker-compose logs -f api
```

**Restart API:**
```bash
docker-compose restart api
```

**Run migrations:**
```bash
docker-compose exec api dotnet ef database update
```

**Stop all services:**
```bash
docker-compose down
```

**Stop and remove volumes:**
```bash
docker-compose down -v
```

## Production Checklist

- [ ] Change all default passwords in `.env`
- [ ] Generate strong JWT secret (32+ characters)
- [ ] Configure HTTPS with SSL certificates
- [ ] Set `ASPNETCORE_ENVIRONMENT=Production`
- [ ] Configure database backups
- [ ] Set up log rotation
- [ ] Configure firewall rules
- [ ] Review security settings
- [ ] Set up monitoring and alerts

## Troubleshooting

**Container won't start:**
```bash
docker-compose logs api
```

**Database connection issues:**
- Verify database container is healthy: `docker-compose ps`
- Check connection string in logs
- Ensure database is fully started before API (healthcheck)

**Port conflicts:**
- Change ports in `docker-compose.yml`
- Default: 5000 (API), 5432 (PostgreSQL)

**Reset everything:**
```bash
docker-compose down -v
docker-compose up -d
```

## Backup and Restore

**Backup PostgreSQL:**
```bash
docker-compose exec postgres pg_dump -U jerp_user jerp_production > backup.sql
```

**Restore PostgreSQL:**
```bash
cat backup.sql | docker-compose exec -T postgres psql -U jerp_user jerp_production
```
