using PrismBlankApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using PrismBlankApp.Modules.Bottom;
using PrismBlankApp.Modules.Content;
using PrismBlankApp.Modules.FlyoutTest;
using PrismBlankApp.Modules.Header;
using PrismBlankApp.Modules.Right;
using PrismBlankApp.Services;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();

            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommandsProxy>();
            containerRegistry.RegisterInstance<IFlyoutService>(Container.Resolve<FlyoutService>());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HeaderModule>();
            moduleCatalog.AddModule<BottomInfoModule>();
            moduleCatalog.AddModule<MainContentModule>();
            moduleCatalog.AddModule<RightModule>();
            moduleCatalog.AddModule<FlyoutModule>();
        }
    }
}
