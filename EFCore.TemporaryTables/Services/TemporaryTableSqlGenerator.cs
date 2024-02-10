using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.TemporaryTables.Services;

internal sealed class TemporaryTableSqlGenerator
{
    private readonly IMigrationsModelDiffer _migrationsModelDiffer;
    private readonly IMigrationsSqlGenerator _migrationsSqlGenerator;
    private readonly TemporaryModelBuilderFactory _temporaryModelBuilderFactory;

    public TemporaryTableSqlGenerator(
        TemporaryModelBuilderFactory temporaryModelBuilderFactory,
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
        stringBuilder.Replace("DROP TABLE", "DROP TABLE IF EXISTS");

        return stringBuilder.ToString();
    }
}