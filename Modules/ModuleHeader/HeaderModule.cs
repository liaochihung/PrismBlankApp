using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismBlankApp.Core;
using PrismBlankApp.Modules.Header.Views;

namespace PrismBlankApp.Modules.Header
{
    public class HeaderModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public HeaderModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.HeaderRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}