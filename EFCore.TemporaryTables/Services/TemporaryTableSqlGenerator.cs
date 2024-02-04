using System.Text;
using EFCore.TemporaryTables.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.TemporaryTables.Services;

internal sealed class TemporaryTableSqlGenerator : ITemporaryTableSqlGenerator
{
    private readonly IMigrationsModelDiffer _migrationsModelDiffer;
    private readonly IMigrationsSqlGenerator _migrationsSqlGenerator;
    private readonly ITemporaryModelBuilderFactory _temporaryModelBuilderFactory;

    public TemporaryTableSqlGenerator(
        ITemporaryModelBuilderFactory temporaryModelBuilderFactory,
        IMigrationsModelDiffer migrationsModelDiffer,
        IMigrationsSqlGenerator migrationsSqlGenerator)
    {
        _temporaryModelBuilderFactory = temporaryModelBuilderFactory;
        _migrationsModelDiffer = migrationsModelDiffer;
        _migrationsSqlGenerator = migrationsSqlGenerator;
    }

    public string CreateTableSql<TEntity>() where TEntity : class
    {
        var relationalFinalizeModel = _temporaryModelBuilderFactory.CreateRelationalModelForTemporaryEntity<TEntity>();

        var sql = CreateSql(target: relationalFinalizeModel);
        return sql;
    }

    public string DropTableSql<TEntity>() where TEntity : class
    {
        var relationalFinalizeModel = _temporaryModelBuilderFactory.CreateRelationalModelForTemporaryEntity<TEntity>();

        var sql = CreateSql(relationalFinalizeModel);
        return sql;
    }

    private string CreateSql(IRelationalModel? source = default, IRelationalModel? target = default)
    {
        var migrationOperations = _migrationsModelDiffer.GetDifferences(source, target);
        var migrationCommands = _migrationsSqlGenerator.Generate(migrationOperations);

        var stringBuilder = new StringBuilder();

        foreach (var migrationCommand in migrationCommands) stringBuilder.Append(migrationCommand.CommandText);

        stringBuilder.Replace("CREATE TABLE", "CREATE TEMPORARY TABLE IF NOT EXISTS");

        return stringBuilder.ToString();
    }
}