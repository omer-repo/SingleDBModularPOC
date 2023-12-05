using Localization.Resources.AbpUi;
using ModuleAuthor.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleAuthor;

[DependsOn(
    typeof(ModuleAuthorApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ModuleAuthorHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ModuleAuthorHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ModuleAuthorResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
