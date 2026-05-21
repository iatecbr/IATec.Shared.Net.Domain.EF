using IATec.Shared.Domain.Contracts.Entities;
using IATec.Shared.Domain.Contracts.UnitOfWorks;

namespace IATec.Shared.Domain.Contracts.Repositories.Generic;

/// <summary>
/// Defines a contract for write operations in a generic repository.
/// </summary>
/// <typeparam name="T">The entity type, constrained to classes implementing <see cref="IEntity"/>.</typeparam>
public interface IWriteRepository<T> : IReadRepository<T>, IUnitOfWork where T : class, IEntity
{
    /// <summary>
    /// Adds a new entity to the repository asynchronously.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    Task AddAsync(T entity);

    /// <summary>
    /// Adds a collection of new entities to the repository asynchronously.
    /// </summary>
    /// <param name="entities">The collection of entities to add.</param>
    Task AddRangeAsync(IEnumerable<T> entities);

    /// <summary>
    /// Removes an entity from the repository asynchronously.
    /// </summary>
    /// <param name="entity">The entity to remove.</param>
    Task RemoveAsync(T entity);

    /// <summary>
    /// Removes a collection of entities from the repository asynchronously.
    /// </summary>
    /// <param name="entities">The collection of entities to remove.</param>
    Task RemoveRangeAsync(IEnumerable<T> entities);

    /// <summary>
    /// Updates an existing entity in the repository asynchronously.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    Task UpdateAsync(T entity);

    /// <summary>
    /// Updates a collection of existing entities in the repository asynchronously.
    /// </summary>
    /// <param name="entities">The collection of entities to update.</param>
    Task UpdateRangeAsync(IEnumerable<T> entities);
}