namespace IATec.Shared.Domain.Contracts.UnitOfWorks;

/// <summary>
/// Defines a contract for persisting changes to the database.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Saves all pending changes to the database asynchronously.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation, containing a boolean indicating success.</returns>
    Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
}