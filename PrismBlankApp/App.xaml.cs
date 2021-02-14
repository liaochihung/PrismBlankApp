using PrismBlankApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Microsoft.Extensions.Logging;
using PrismBlankApp.Modules.Bottom;
using PrismBlankApp.Modules.Content;
using PrismBlankApp.Modules.FlyoutTest;
using PrismBlankApp.Modules.Header;
using PrismBlankApp.Modules.Right;
using PrismBlankApp.Services;
using PrismBlankApp.Services.Interfaces;
using Unity.Lifetime;

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
            #region Log
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "log/file.txt" };
            config.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;

            var factory = new NLog.Extensions.Logging.NLogLoggerFactory();
            Microsoft.Extensions.Logging.ILogger logger = factory.CreateLogger("");

            containerRegistry.RegisterInstance<Microsoft.Extensions.Logging.ILogger>(logger);

            var log = Container.Resolve<Microsoft.Extensions.Logging.ILogger>();
            log.LogInformation("Test in RegisterTypes");
            #endregion

            //containerRegistry.RegisterInstance(typeof(ILocalizerService),
            //    "LocalizerService",
            //        new LocalizerService("zh-TW"),
            //            new ContainerControlledLifetimeManager());
            //containerRegistry.RegisterInstance<ILocalizerService, LocalizerService("zh-TW")>(new ContainerControlledLifetimeManager());
            containerRegistry.RegisterSingleton<ILocalizerService, LocalizerService>();

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
