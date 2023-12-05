using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ModuleAuthor.EntityFrameworkCore;

[DependsOn(
    typeof(ModuleAuthorDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ModuleAuthorEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ModuleAuthorDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
