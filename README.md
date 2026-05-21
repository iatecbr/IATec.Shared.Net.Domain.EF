# IATec.Shared.Domain.EF

This is a shared .NET library developed by **IATec Solutions | Platform Team** to accelerate and standardize the development of projects across the company.

It provides core abstractions and contracts for **Entity Framework (EF)** based domain layers, including:

- **Unit of Work** (`IUnitOfWork`) — Persist changes to the database in a transactional scope.
- **Transactions** (`ITransaction`) — Manage explicit database transactions (begin, commit, rollback).
- **Generic Repositories** (`IReadRepository<T>`, `IWriteRepository<T>`, `IGenericRepositoryQuery`) — Standard CRUD and query contracts for domain entities.

## Installation

This package is published to the internal IATec NuGet feed. Install it via the .NET CLI:

```bash
dotnet add package IATec.Shared.Domain.EF
```

Or via the NuGet Package Manager:

```powershell
Install-Package IATec.Shared.Domain.EF
```

## Usage

Reference the contracts in your domain / infrastructure layers to enforce consistent repository and unit-of-work patterns across all IATec .NET projects.

Example interface usage:

```csharp
using IATec.Shared.Domain.Contracts.Repositories.Generic;
using IATec.Shared.Domain.Contracts.UnitOfWorks;

public class MyService
{
    private readonly IWriteRepository<MyEntity> _repository;

    public MyService(IWriteRepository<MyEntity> repository)
    {
        _repository = repository;
    }

    public async Task CreateAsync(MyEntity entity)
    {
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
    }
}
```

## Target Frameworks

- .NET 8.0
- .NET 9.0
- .NET 10.0

## Dependencies

- `IATec.Shared.Domain` (v1.2.0)

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

## Changelog

See the [CHANGELOG](CHANGELOG.md) file for a detailed history of changes, including added, changed, fixed, and removed features across versions.

## Contributing

This package is maintained by the **IATec | Solution | Platform Team**. For questions or suggestions, reach out through the internal development channels.
