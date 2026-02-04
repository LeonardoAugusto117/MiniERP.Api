📦 BorealERP.Api

Backend de um Mini ERP desenvolvido em ASP.NET Core Web API, utilizando PostgreSQL, Entity Framework Core e Swagger.

O objetivo do projeto é construir uma API RESTful para gestão básica de um ERP, cobrindo o fluxo completo de clientes, produtos, pedidos e controle de estoque.

🚧 Projeto em fase inicial — atualmente contém a estrutura base, configuração do ambiente e primeiras migrations.

🎯 Objetivo do Projeto

O BorealERP foi pensado para simular um ERP real em pequena escala, com foco em boas práticas de backend, organização de código e regras de negócio.

O sistema permitirá:

Cadastro e gerenciamento de clientes

Cadastro e gerenciamento de produtos

Controle de estoque

Criação de pedidos de venda

Relacionamento entre cliente → pedido → produtos

Baixa automática de estoque com base nos pedidos realizados

🔄 Fluxo de Funcionamento do Sistema

1️⃣ Clientes

Cadastro completo de clientes

Possibilidade de ativar/desativar clientes (soft delete)

Clientes desativados não podem realizar pedidos

2️⃣ Produtos

Cadastro de produtos

Produto possui:

Preço

Status (ativo/inativo)

Quantidade em estoque

Produtos inativos não podem ser utilizados em pedidos

3️⃣ Pedidos

Criação de pedidos vinculados a:

Um cliente

Um ou mais produtos

O pedido:

Calcula automaticamente o valor total

Registra os itens e quantidades

4️⃣ Estoque

Tela/módulo próprio de estoque

O estoque:

Lê os pedidos existentes

Realiza a baixa automática dos produtos vendidos

Exibe o saldo atual de cada produto

🛠️ Tecnologias Utilizadas

.NET 8 (LTS)

ASP.NET Core Web API

Entity Framework Core

PostgreSQL

Swagger / OpenAPI

MiniERP.Api
│
├── Controllers      # Endpoints da API
├── Models           # Entidades do domínio
├── Data             # DbContext e configurações do EF Core
├── Services         # Regras de negócio
├── Repositories     # Acesso a dados
│
├── Program.cs
├── appsettings.json
└── README.md

⚙️ Configuração do Ambiente
Pré-requisitos

Visual Studio 2022+

.NET 8 SDK

PostgreSQL

pgAdmin 4

🚀 Como Rodar o Projeto Localmente

1️⃣ Clonar o repositório

git clone https://github.com/seu-usuario/MiniERP.Api.git
cd MiniERP.Api

2️⃣ Configurar a Connection String

Edite o arquivo appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=boreal_erp_db;Username=postgres;Password=SUA_SENHA"
  }
}

3️⃣ Criar o banco de dados

No pgAdmin, crie um banco chamado:

boreal_erp_db

4️⃣ Criar as migrations e tabelas

dotnet ef migrations add InitialCreate
dotnet ef database update

5️⃣ Executar o projeto

Via Visual Studio:

Clique em Run

Ou via terminal:

dotnet run

Acesse o Swagger:

https://localhost:PORTA/swagger

Exemplo:

https://localhost:7070/swagger

📄 Documentação da API

Toda a documentação dos endpoints é gerada automaticamente via Swagger:

/swagger

🧩 Funcionalidades Planejadas

Cadastro de clientes

Ativação/desativação de clientes

Cadastro de produtos

Controle de estoque

Criação de pedidos

Relacionamento cliente → pedido → produtos

Cálculo automático do total do pedido

Baixa automática de estoque

Autenticação e autorização (JWT)

Versionamento de API

📌 Status do Projeto

🟡 Em desenvolvimento (fase inicial)
Atualmente contém a estrutura base do projeto, configuração do ambiente e primeiras migrations.

👨‍💻 Autor

Leonardo Augusto
Projeto para estudo e prática de ASP.NET Core Web API, Entity Framework Core e PostgreSQL.
