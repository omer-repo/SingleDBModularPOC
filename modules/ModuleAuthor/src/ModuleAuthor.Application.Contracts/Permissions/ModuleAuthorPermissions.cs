using Volo.Abp.Reflection;

namespace ModuleAuthor.Permissions;

public class ModuleAuthorPermissions
{
    public const string GroupName = "ModuleAuthor";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModuleAuthorPermissions));
    }
}
