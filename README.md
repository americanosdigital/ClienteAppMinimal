# ClienteAppMinimal

A minimal example project built with .NET 9 demonstrating basic Customer Registration and Query features. This solution follows Domain-Driven Design (DDD) principles using a layered architecture and a Blazor frontend UI.

## 🚀 Technologies Used

- .NET 9
- Minimal APIs
- Blazor (UI Layer)
- DDD Architecture (Domain, Infrastructure, API, UI) to store in memory

## 📁 Project Structure

```
ClienteAppMinimal/
│
├── Domain/           # Domain entities, interfaces, value objects
├── Infra/            # Repositories, database context (EF Core or similar)
├── API/              # Minimal API endpoints for Customers
└── UI/               # Blazor frontend for interacting with the API
```

## ⚙️ How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/americanosdigital/ClienteAppMinimal.git
   cd ClienteAppMinimal
   ```

2. Restore dependencies and build the solution:
   ```bash
   dotnet restore
   dotnet build
   ```

3. Run the API project:
   ```bash
   cd API
   dotnet run
   ```

4. Run the Blazor UI:
   ```bash
   cd UI
   dotnet run
   ```

## ✍️ Features

- ✅ Register new customer (Name, Email)
- 🔍 Query registered customers
- ✅ Clean separation of concerns following DDD principles
- 🔄 API and UI decoupled for scalability

## 📬 Contact

Created by Wellington Americano 
– [americanodigital@gmail.com](mailto:americanodigital@gmail.com)
– [GitHub Profile](https://github.com/americanosdigital)
