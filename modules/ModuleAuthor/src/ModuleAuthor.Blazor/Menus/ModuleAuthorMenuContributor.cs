using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ModuleAuthor.Blazor.Menus;

public class ModuleAuthorMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ModuleAuthorMenus.Prefix, displayName: "ModuleAuthor", "/ModuleAuthor", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
