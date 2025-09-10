# Gestão de Cadastro

Sistema de gestão de cadastro de pessoas desenvolvido em .NET 8 com arquitetura limpa (Clean Architecture), incluindo autenticação JWT e versionamento de API.

## 📋 Visão Geral

Este projeto é uma API REST para gerenciamento de cadastros de pessoas, implementando boas práticas de desenvolvimento como Clean Architecture, DDD (Domain-Driven Design), validações robustas e testes unitários.

## 🏗️ Arquitetura

O projeto segue os princípios da Clean Architecture, organizando o código em camadas bem definidas:

```
GestaoDeCadastro/
├── GestaoDeCadastro.Domain/          # Camada de Domínio
├── GestaoDeCadastro.Infraestructure/ # Camada de Infraestrutura
├── GestaoDeCadastro.Services/        # Camada de Aplicação
├── GestaoDeCadastro.Interface/       # Camada de Apresentação (API)
├── GestaoDeCadastro.Crosscutting/    # DTOs e Utilitários
└── GestaoDeCadastro.Tests/          # Testes Unitários
```

### Camadas do Projeto

- **Domain**: Entidades de negócio, contratos e exceções
- **Infrastructure**: Implementação de repositórios, contexto do banco e persistência
- **Services**: Lógica de aplicação e serviços de negócio
- **Interface**: Controllers da API REST
- **Crosscutting**: DTOs, utilitários e objetos de transferência
- **Tests**: Testes unitários e de integração

## 🚀 Tecnologias Utilizadas

- **.NET 8.0** - Framework principal
- **ASP.NET Core Web API** - Para criação da API REST
- **Entity Framework Core** - ORM para acesso a dados
- **JWT Bearer Authentication** - Autenticação via tokens
- **Swagger/OpenAPI** - Documentação da API
- **xUnit** - Framework de testes

## 🔧 Instalação

### Pré-requisitos
- .NET 8.0 SDK
- Visual Studio 2022 ou VS Code

### Como executar

1. **Clone o repositório**
```bash
git clone <url-do-repositorio>
cd GestaoDeCadastro
```

2. **Restaure as dependências**
```bash
dotnet restore
```

3. **Execute o projeto**
```bash
dotnet run --project GestaoDeCadastro.Interface
```

4. **Acesse a documentação**
- Swagger UI: `http://localhost:5000` ou `https://localhost:5001`

## 📊 Funcionalidades

- **Autenticação JWT** - Login seguro com tokens
- **CRUD de Pessoas** - Create, Read, Update, Delete
- **Versionamento de API** - V1 (básica) e V2 (com endereço)
- **Validações robustas** - CPF, email, telefone
- **Testes unitários** - Cobertura completa do código
