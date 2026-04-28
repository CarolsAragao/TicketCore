# TicketCore

API para gerenciamento de chamados técnicos, desenvolvida com `ASP.NET Core` e organizada em camadas.

## Tecnologias

- `.NET 10`
- `ASP.NET Core Web API`
- `Entity Framework Core`
- `PostgreSQL`
- `Npgsql`

## Arquitetura

O projeto está estruturado nas seguintes camadas:

- `TicketCore.API`
- `TicketCore.Application`
- `TicketCore.Domain`
- `TicketCore.Infrastructure`
- `TicketCore.IoC`

## Estrutura

```text
TicketCore
├── TicketCore.API
├── TicketCore.Application
├── TicketCore.Domain
├── TicketCore.Infrastructure
├── TicketCore.IoC
└── TicketCore.slnx
```

## Funcionalidades em desenvolvimento

- cadastro de usuários
- autenticação e autorização
- gerenciamento de chamados
- controle de status e prioridade
- histórico de interações

## Status atual

Atualmente o projeto contém:

- estrutura inicial da solução
- entidades de domínio
- DTOs e serviços de aplicação
- configuração de injeção de dependência
- configuração inicial de `DbContext`
- endpoint inicial para usuário

## Executando o projeto

### Configurar connection string

Adicione a string de conexão no arquivo `TicketCore.API/appsettings.json`.

Exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=ticketcoredb;Username=postgres;Password=postgres"
  }
}
```

### Restaurar dependências

```bash
dotnet restore
```

### Executar a aplicação

```bash
dotnet run --project TicketCore.API/TicketCore.API/TicketCore.API.csproj
```

## Banco de dados

O projeto utiliza `PostgreSQL` como banco de dados principal, com suporte planejado para uso em ambiente containerizado com Docker.

## Próximos passos

- implementar persistência completa de usuários
- criar migrations
- adicionar autenticação com JWT
- iniciar módulo de chamados
- preparar ambiente com Docker
