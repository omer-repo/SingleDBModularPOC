using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace ModuleAuthor.Blazor.WebAssembly;

[DependsOn(
    typeof(ModuleAuthorBlazorModule),
    typeof(ModuleAuthorHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ModuleAuthorBlazorWebAssemblyModule : AbpModule
{

}
