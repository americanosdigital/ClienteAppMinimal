# ClienteAppMinimal

Projeto exemplo minimalista desenvolvido com .NET 9, demonstrando funcionalidades básicas de **cadastro e consulta de clientes**. A arquitetura segue os princípios de Domain-Driven Design (DDD) em camadas e utiliza Blazor na camada de interface (UI).

## 🚀 Tecnologias Utilizadas

- .NET 9
- Minimal APIs
- Blazor (UI)
- Arquitetura DDD (Domain, Infraestrutura, API, UI)

## 📁 Estrutura do Projeto

```
ClienteAppMinimal/
│
├── Domain/           # Entidades de domínio, interfaces e objetos de valor
├── Infra/            # Repositórios e contexto de banco de dados (EF Core ou similar)
├── API/              # Endpoints da Minimal API para Clientes
└── UI/               # Interface Blazor para interação com a API
```

## ⚙️ Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/americanosdigital/ClienteAppMinimal.git
   cd ClienteAppMinimal
   ```

2. Restaure as dependências e construa a solução:
   ```bash
   dotnet restore
   dotnet build
   ```

3. Execute o projeto da API:
   ```bash
   cd API
   dotnet run
   ```

4. Execute a interface Blazor:
   ```bash
   cd UI
   dotnet run
   ```

## ✍️ Funcionalidades

- ✅ Cadastro de novo cliente (Nome, Email, CPF)
- 🔍 Consulta de clientes cadastrados
- ✅ Separação clara de responsabilidades com base em DDD
- 🔄 API e UI desacopladas

## 📬 Contato

Criado por Wellington Americano – [Perfil no GitHub](https://github.com/americanosdigital)
