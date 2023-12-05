namespace ModuleAuthor;

public static class ModuleAuthorDbProperties
{
    public static string DbTablePrefix { get; set; } = "ModuleAuthor";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ModuleAuthor";
}
