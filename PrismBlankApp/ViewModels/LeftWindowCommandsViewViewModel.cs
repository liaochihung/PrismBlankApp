using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Regions;
using PrismBlankApp.Core.Mvvm;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.ViewModels
{
    public class LeftWindowCommandsViewViewModel : RegionViewModelBase
    {
        public LeftWindowCommandsViewViewModel(IRegionManager regionManager, IMessageService messageService)
            :base(regionManager)
        {

        }
    }
}
