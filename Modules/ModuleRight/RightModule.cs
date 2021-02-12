using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismBlankApp.Core;
using PrismBlankApp.Modules.Right.Views;

namespace PrismBlankApp.Modules.Right
{
    public class RightModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RightModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.RightRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}