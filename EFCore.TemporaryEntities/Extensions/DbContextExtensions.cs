using EFCore.TemporaryTables.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCore.TemporaryTables.Extensions;

public static class DbContextExtensions
{
    public static async Task<DbSet<TEntity>> CreateTemporaryEntityAsync<TEntity>(
        this DbContext context,
        CancellationToken cancellationToken = default)
        where TEntity : class
    {
        await context.GetService<ICreateTemporaryEntityOperation>().ExecuteAsync<TEntity>(cancellationToken);

        return context.Set<TEntity>();
    }

    public static Task DropTemporaryEntityAsync<TEntity>(
        this DbContext context,
        CancellationToken cancellationToken = default)
        where TEntity : class
    {
        return context
            .GetService<IDropTemporaryEntityOperation>()
            .ExecuteAsync<TEntity>(cancellationToken);
    }
}