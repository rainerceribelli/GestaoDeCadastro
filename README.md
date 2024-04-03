# Gestão de Cadastro - Serviço de Aplicação de Pessoas

Este serviço de aplicação é responsável pela gestão de pessoas, tanto físicas quanto jurídicas, no sistema de gestão de cadastros.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Plataforma**: .NET
- **Banco de Dados**: SQL Server
- **ORM**: Entity Framework Core
- **Documentação de API**: Swagger

## Estrutura do Projeto

O projeto está estruturado da seguinte forma:

- `GestaoDeCadastro.Crosscutting.DTO.Cadastro`: Contém os objetos de transferência de dados (DTOs) relacionados ao cadastro de pessoas.
- `GestaoDeCadastro.Domain.Entities.Cadastro`: Contém as entidades de domínio relacionadas ao cadastro de pessoas.
- `GestaoDeCadastro.Infraestructure.Model`: Contém o contexto do banco de dados e as configurações do Entity Framework Core.
- `GestaoDeCadastro.Infraestructure.Persistance.Repository`: Contém os repositórios para acesso aos dados das entidades.
- `GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro`: Contém as unidades de trabalho relacionadas ao cadastro de pessoas.
- `GestaoDeCadastro.Service.ApplicationServices.Base`: Contém a classe base para serviços de aplicação.
- `GestaoDeCadastro.Service.ApplicationServices.Cadastro`: Contém o serviço de aplicação para gestão de pessoas.
  
## Configuração do Projeto

1. Certifique-se de ter o SDK do .NET instalado em sua máquina.
2. Configure a conexão com o banco de dados no arquivo `appsettings.json` no projeto principal.
3. Execute o comando `dotnet build` para compilar o projeto.
4. Execute o comando `dotnet run` para iniciar a aplicação.
