using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Prism.Regions;
using PrismBlankApp.Core.Mvvm;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.ViewModels
{
    public class RightWindowCommandsViewViewModel : RegionViewModelBase
    {
        public RightWindowCommandsViewViewModel(IRegionManager regionManager, IMessageService messageService)
            : base(regionManager)
        {

        }
    }
}
