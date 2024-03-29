using EFCore.TemporaryTables.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.TemporaryTables.Extensions;

public static class ModelBuilderExtensions
{
    public static ModelBuilder TemporaryEntity<TEntity>(
        this ModelBuilder modelBuilder,
        IInfrastructure<IServiceProvider> infrastructure,
        Action<EntityTypeBuilder<TEntity>> configure) where TEntity : class
    {
        var entityTypeBuilder = modelBuilder.Entity<TEntity>();

        var temporaryTableConfiguration = infrastructure.GetService<IAddTemporaryTableConfiguration>();
        temporaryTableConfiguration.Add<TEntity>(configure);

        configure(entityTypeBuilder);
        entityTypeBuilder.Metadata.SetIsTableExcludedFromMigrations(true);

        return modelBuilder;
    }
}