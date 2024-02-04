using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCore.TemporaryTables.Extensions;

public static class DbContextOptionsBuilderExtensions
{
    private static readonly TemporaryTableOptionsExtension TemporaryTableOptionsExtension = new();

    public static DbContextOptionsBuilder UseTemporaryTables(this DbContextOptionsBuilder optionsBuilder)
    {
        var extension = optionsBuilder.Options.FindExtension<TemporaryTableOptionsExtension>();
        if (!ReferenceEquals(extension, default)) return optionsBuilder;
        
        var infrastructure = optionsBuilder as IDbContextOptionsBuilderInfrastructure;
        infrastructure.AddOrUpdateExtension(TemporaryTableOptionsExtension);

        return optionsBuilder;
    }
}