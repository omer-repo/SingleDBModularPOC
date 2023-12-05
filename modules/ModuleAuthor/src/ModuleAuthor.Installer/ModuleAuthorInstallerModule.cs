using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ModuleAuthor;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ModuleAuthorInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleAuthorInstallerModule>();
        });
    }
}
