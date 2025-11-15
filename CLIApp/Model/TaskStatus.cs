namespace CLIApp;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaskStatus
{
    Todo,
    InProgress,
    Done
}
