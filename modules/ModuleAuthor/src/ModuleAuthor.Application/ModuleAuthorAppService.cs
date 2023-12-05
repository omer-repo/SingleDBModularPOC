using ModuleAuthor.Localization;
using Volo.Abp.Application.Services;

namespace ModuleAuthor;

public abstract class ModuleAuthorAppService : ApplicationService
{
    protected ModuleAuthorAppService()
    {
        LocalizationResource = typeof(ModuleAuthorResource);
        ObjectMapperContext = typeof(ModuleAuthorApplicationModule);
    }
}
