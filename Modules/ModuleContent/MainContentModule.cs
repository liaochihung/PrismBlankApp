using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismBlankApp.Core;
using PrismBlankApp.Modules.Content.Views;

namespace PrismBlankApp.Modules.Content
{
    public class MainContentModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MainContentModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}