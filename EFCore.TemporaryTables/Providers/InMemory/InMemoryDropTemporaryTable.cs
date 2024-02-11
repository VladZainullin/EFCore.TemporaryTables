using EFCore.TemporaryTables.Abstractions;

namespace EFCore.TemporaryTables.Providers.InMemory;

internal sealed class InMemoryDropTemporaryTable : IDropTemporaryTableOperation
{
    public Task ExecuteAsync<TEntity>(CancellationToken cancellationToken = default) where TEntity : class
    {
        return Task.CompletedTask;
    }

    public void Execute<TEntity>() where TEntity : class
    {
    }
}