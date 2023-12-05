using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ModuleAuthor;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModuleAuthorDomainSharedModule)
)]
public class ModuleAuthorDomainModule : AbpModule
{

}
