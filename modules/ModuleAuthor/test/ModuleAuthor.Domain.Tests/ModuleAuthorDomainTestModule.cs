using ModuleAuthor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ModuleAuthor;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ModuleAuthorEntityFrameworkCoreTestModule)
    )]
public class ModuleAuthorDomainTestModule : AbpModule
{

}
