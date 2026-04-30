# Comandos uteis

## Migrations

Criar uma nova migration:

```powershell
dotnet ef migrations add InitialCreate --project .\TicketCore.Infrastructure\TicketCore.Infrastructure.csproj --startup-project .\TicketCore.API\TicketCore.API\TicketCore.API.csproj --output-dir Migrations
```

Aplicar as migrations no banco:

```powershell
dotnet ef database update --project .\TicketCore.Infrastructure\TicketCore.Infrastructure.csproj --startup-project .\TicketCore.API\TicketCore.API\TicketCore.API.csproj
```

## Reset do banco

Resetar o banco para testes:

```powershell
.\reset-db.ps1
```
