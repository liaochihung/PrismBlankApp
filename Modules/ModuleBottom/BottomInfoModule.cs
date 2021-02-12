using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismBlankApp.Core;
using PrismBlankApp.Modules.Bottom.Views;

namespace PrismBlankApp.Modules.Bottom
{
    public class BottomInfoModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public BottomInfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.BottomRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}