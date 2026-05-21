using System.Linq.Expressions;
using IATec.Shared.Domain.Contracts.Entities;

namespace IATec.Shared.Domain.Contracts.Repositories.Generic;

/// <summary>
/// Defines a contract for querying entities with eager loading capabilities.
/// </summary>
public interface IGenericRepositoryQuery
{
    /// <summary>
    /// Returns a queryable for the specified entity type, optionally including related properties.
    /// </summary>
    /// <typeparam name="T">The entity type, constrained to classes implementing <see cref="IEntity"/>.</typeparam>
    /// <param name="includeProperties">Optional related properties to eagerly load.</param>
    /// <returns>An <see cref="IQueryable{T}"/> that can be further composed.</returns>
    IQueryable<T> Query<T>(params Expression<Func<T, object>>[] includeProperties) where T : class, IEntity;
}