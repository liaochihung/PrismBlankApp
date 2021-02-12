using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismBlankApp.Core;
using PrismBlankApp.Modules.FlyoutTest.Views;

namespace PrismBlankApp.Modules.FlyoutTest
{
    public class FlyoutModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(ViewA));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}