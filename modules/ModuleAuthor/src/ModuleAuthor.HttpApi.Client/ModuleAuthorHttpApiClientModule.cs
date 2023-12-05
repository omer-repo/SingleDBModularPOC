using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ModuleAuthor;

[DependsOn(
    typeof(ModuleAuthorApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ModuleAuthorHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ModuleAuthorApplicationContractsModule).Assembly,
            ModuleAuthorRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleAuthorHttpApiClientModule>();
        });

    }
}
