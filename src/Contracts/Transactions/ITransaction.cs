namespace IATec.Shared.Domain.Contracts.Transactions;

/// <summary>
/// Defines a contract for managing database transactions.
/// </summary>
public interface ITransaction
{
    /// <summary>
    /// Begins a new transaction.
    /// </summary>
    void BeginTransaction();

    /// <summary>
    /// Commits the current transaction.
    /// </summary>
    void CommitTransaction();

    /// <summary>
    /// Rolls back the current transaction.
    /// </summary>
    void RollbackTransaction();
}