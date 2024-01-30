using EFCore.TemporaryTables.Attributes;

namespace Sample;

[TemporaryTable]
public sealed class People
{
    public required int Id { get; init; }

    public required string Name { get; init; }

    public required string Surname { get; init; }

    public required DateTime DateOfBirth { get; init; }

    public required Gender Gender { get; init; }

    public required bool HasChildren { get; init; }

    public required decimal Salary { get; set; }
}