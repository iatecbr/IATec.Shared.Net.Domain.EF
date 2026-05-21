using IATec.Shared.Domain.Contracts.Entities;

namespace IATec.Shared.Domain.Contracts.Repositories.Generic;

/// <summary>
/// Defines a contract for read operations in a generic repository.
/// </summary>
/// <typeparam name="T">The entity type, constrained to classes implementing <see cref="IEntity"/>.</typeparam>
public interface IReadRepository<T> where T : class, IEntity
{
    /// <summary>
    /// Retrieves all entities from the repository asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation, containing a list of all entities.</returns>
    Task<List<T>> GetAllAsync();

    /// <summary>
    /// Retrieves an entity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>A task that represents the asynchronous operation, containing the entity if found; otherwise, <see langword="null"/>.</returns>
    Task<T?> GetByIdAsync(int id);
}