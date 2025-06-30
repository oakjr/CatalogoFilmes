# 🎬 Catálogo de Filmes - Projeto Final .NET 9

Este é um projeto simples de API REST em .NET 9 desenvolvido como avaliação do curso de Back-End no IATEC Academy. O sistema simula um catálogo de filmes com dados armazenados em memória, aplicando os princípios de Clean Code, SOLID, injeção de dependência, Repository Pattern e testes unitários com Moq.

---

## 📚 Descrição
Esta API simula um catálogo de filmes com operações básicas de CRUD (Create, Read, Update, Delete), utilizando dados mockados em memória (sem banco de dados). O projeto é dividido em camadas para promover organização, testabilidade e boas práticas de desenvolvimento.

---

## 📚 Funcionalidades

- Listar todos os filmes
- Buscar filme por ID
- Adicionar novo filme
- Atualizar filme existente
- Remover filme

---

## 🏗️ Estrutura do Projeto

- `CatalogoFilmes.API`: Projeto principal da API com os controllers
- `CatalogoFilmes.Application`: Camada de aplicação com serviços e repositório mockado
- `CatalogoFilmes.Domain`: Entidades e interfaces de domínio
- `CatalogoFilmes.Tests`: Testes unitários com xUnit e Moq

---

## 🚀 Como rodar o projeto

    1. Clone o repositório:

    git clone https://github.com/oakjr/CatalogoFilmes.git
    cd CatalogoFilmes

    2. Restaure os pacotes e compile a solução:

    dotnet restore
    dotnet build

    3. Execute a API:

    dotnet run --project CatalogoFilmes.API

    4. Acesse a documentação Swagger:

    http://localhost:5191/swagger/index.html

---

## 🧪 Como executar os testes

    1. Acesse a raiz do projeto:

    cd CatalogoFilmes

    2. Execute os testes com o seguinte comando:
    
    dotnet test

    3. O terminal exibirá os resultados dos testes unitários, indicando quais passaram ou falharam.

    Os testes estão localizados no projeto CatalogoFilmes.Tests e utilizam o framework xUnit com Moq para simular o repositório.

---

## 🛠️ Tecnologias utilizadas
- .NET 9 – Framework principal para desenvolvimento da API
- ASP.NET Core Web API – Para criação dos endpoints REST
- Entity Framework (sem banco de dados) – Utilizado com repositório mockado
- xUnit – Framework de testes unitários
- Moq – Biblioteca para criação de mocks nos testes
- Swagger – Documentação automática da API
- C# – Linguagem de programação utilizada
- Injeção de Dependência – Para desacoplamento entre camadas
- Repository Pattern – Para abstração do acesso aos dados
- Clean Code & SOLID – Princípios aplicados em toda a estrutura do projeto