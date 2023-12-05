using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ModuleAuthor;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModuleAuthorHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ModuleAuthorConsoleApiClientModule : AbpModule
{

}
