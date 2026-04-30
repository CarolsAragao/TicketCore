# Roadmap

## 1. Modelagem inicial

- definir entidades principais
- revisar enums de status, prioridade e perfil
- validar regras de negocio do MVP

## 2. Estrutura da API

- organizar camadas `API`, `Application`, `Domain`, `Infrastructure` e `IoC`
- revisar dependencias entre projetos
- consolidar configuracao base da aplicacao

## 3. Banco de dados e persistencia

- configurar `ApplicationDbContext`
- criar e manter migrations
- estruturar repositórios
- conectar a API ao PostgreSQL

## 4. Usuarios

- concluir criacao de usuario
- persistir usuario no banco
- validar hash de senha
- preparar base para autenticacao

## 5. Autenticacao e autorizacao

- login com JWT
- perfis de acesso
- protecao de rotas

## 6. Chamados

- criar entidade e fluxo de chamados
- abrir, listar e atualizar chamados
- aplicar status e prioridade

## 7. Comentarios e historico

- adicionar comentarios em chamados
- registrar logs de acoes
- manter historico de interacoes

## 8. Dashboard

- exibir indicadores principais
- contagem por status
- contagem por prioridade

## 9. Docker e ambiente

- manter banco em container
- preparar API para containerizacao
- revisar fluxo de reset e testes locais

## 10. Evolucao do projeto

- melhorar validacoes
- adicionar testes
- planejar integracao com IA
