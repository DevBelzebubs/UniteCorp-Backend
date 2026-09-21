# UniteCorp — MS ASP.NET Core

Microservicio **ASP.NET Core** (minimal API, .NET 10) de UniteCorp (scaffold por defecto, sin dominio).

## Requisitos

- .NET SDK 10+
- PostgreSQL (o `docker compose up -d`)

## Ejecutar

```bash
dotnet run
```

- Health: http://localhost:5080/health
- Raíz: http://localhost:5080/
- OpenAPI (dev): http://localhost:5080/openapi/v1.json

## Build / test

```bash
dotnet build
dotnet run --urls http://localhost:5080 &
curl http://localhost:5080/health
```

## Base de datos

Conexión `ConnectionStrings:DefaultConnection` apunta a PostgreSQL en `localhost:5433`,
BD `unitecorp_dotnet` (iniciada por `docker-compose.yml` en la raíz de `UniteCorp-Back`).
El `AppDbContext` (EF Core/Npgsql) está registrado pero sin entidades.