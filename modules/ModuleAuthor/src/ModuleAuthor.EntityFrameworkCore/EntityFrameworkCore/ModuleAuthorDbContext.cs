using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleAuthor.EntityFrameworkCore;

[ConnectionStringName(ModuleAuthorDbProperties.ConnectionStringName)]
public class ModuleAuthorDbContext : AbpDbContext<ModuleAuthorDbContext>, IModuleAuthorDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ModuleAuthorDbContext(DbContextOptions<ModuleAuthorDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureModuleAuthor();
    }
}
