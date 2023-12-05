using ModuleAuthor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ModuleAuthor.Permissions;

public class ModuleAuthorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModuleAuthorPermissions.GroupName, L("Permission:ModuleAuthor"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModuleAuthorResource>(name);
    }
}
