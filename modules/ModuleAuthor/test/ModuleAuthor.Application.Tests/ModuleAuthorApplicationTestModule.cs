using Volo.Abp.Modularity;

namespace ModuleAuthor;

[DependsOn(
    typeof(ModuleAuthorApplicationModule),
    typeof(ModuleAuthorDomainTestModule)
    )]
public class ModuleAuthorApplicationTestModule : AbpModule
{

}
