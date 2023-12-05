using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ModuleAuthor;

[DependsOn(
    typeof(ModuleAuthorDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ModuleAuthorApplicationContractsModule : AbpModule
{

}
