using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleAuthor.EntityFrameworkCore;

[ConnectionStringName(ModuleAuthorDbProperties.ConnectionStringName)]
public interface IModuleAuthorDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
