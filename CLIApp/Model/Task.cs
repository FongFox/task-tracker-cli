namespace CLIApp;

using System.Text.Json.Serialization;

public record class Task
{
    public required int Id { get; init; }; 
    public required string Description { get; init; };
    public required TaskStatus Status { get; init; };
    public required DateTimeOffset CreatedAt { get; init; };
    public required DateTimeOffset UpdatedAt { get; init; };
}
