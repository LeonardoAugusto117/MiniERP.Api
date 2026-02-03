📦 MiniERP.Api

Backend de um Mini ERP desenvolvido em ASP.NET Core Web API, com PostgreSQL, Entity Framework Core e Swagger.

O objetivo do projeto é criar uma API simples para gestão básica de um ERP, permitindo:

Cadastro de clientes

Cadastro de produtos

Criação de pedidos de venda

🚧 Projeto em fase inicial — atualmente contém apenas a estrutura base e configuração do ambiente.

🛠️ Tecnologias Utilizadas

.NET 8 (LTS)

ASP.NET Core Web API

Entity Framework Core

PostgreSQL

Swagger (OpenAPI)

📁 Estrutura do Projeto
MiniERP.Api
│
├── Controllers
├── Models
├── Data
├── Services
├── Repositories
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
    "DefaultConnection": "Host=localhost;Port=5432;Database=minierp_db;Username=postgres;Password=SUA_SENHA"
  }
}

3️⃣ Criar o banco de dados

No pgAdmin, crie um banco chamado:

minierp_db

4️⃣ Criar as migrations e tabelas
dotnet ef migrations add InitialCreate
dotnet ef database update

5️⃣ Executar o projeto

No Visual Studio:

Clique em Run

Ou via terminal:

dotnet run


Acesse o Swagger:

https://localhost:PORTA/swagger


Exemplo:

https://localhost:7070/swagger

📄 Documentação da API

A documentação dos endpoints é gerada automaticamente via Swagger:

/swagger

🧩 Funcionalidades Planejadas

 Cadastro de clientes

 Cadastro de produtos

 Criação de pedidos

 Relacionamento cliente → pedido

 Cálculo de total do pedido

 Autenticação (futuro)

 Versionamento de API

📌 Status do Projeto

🟡 Em desenvolvimento (fase inicial)
Atualmente contém apenas a estrutura base do projeto e configuração do ambiente.

👨‍💻 Autor

Projeto desenvolvido por [Seu Nome]
Estudo e prática de ASP.NET Core + PostgreSQL. MiniERP.Api
