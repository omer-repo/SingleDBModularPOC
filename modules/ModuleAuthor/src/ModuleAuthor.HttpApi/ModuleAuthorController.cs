using ModuleAuthor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleAuthor;

public abstract class ModuleAuthorController : AbpControllerBase
{
    protected ModuleAuthorController()
    {
        LocalizationResource = typeof(ModuleAuthorResource);
    }
}
