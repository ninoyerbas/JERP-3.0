# src/JERP.Api/Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY ["src/JERP.Api/JERP.Api.csproj", "src/JERP.Api/"]
COPY ["src/JERP.Application/JERP.Application.csproj", "src/JERP.Application/"]
COPY ["src/JERP.Core/JERP.Core.csproj", "src/JERP.Core/"]
COPY ["src/JERP.Infrastructure/JERP.Infrastructure.csproj", "src/JERP.Infrastructure/"]
COPY ["src/JERP.Compliance/JERP.Compliance.csproj", "src/JERP.Compliance/"]

# Restore dependencies
RUN dotnet restore "src/JERP.Api/JERP.Api.csproj"

# Copy everything else
COPY . .

# Build
WORKDIR "/src/src/JERP.Api"
RUN dotnet build "JERP.Api.csproj" -c Release -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "JERP.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Create logs directory
RUN mkdir -p /app/logs && chmod 777 /app/logs

ENTRYPOINT ["dotnet", "JERP.Api.dll"]
