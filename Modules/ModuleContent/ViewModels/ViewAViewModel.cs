﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Regions;
using PrismBlankApp.Core.Mvvm;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.Modules.Content.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _moduleContent;
        public string ModuleContent
        {
            get => _moduleContent;
            set
            {
                _moduleContent = value;
                SetProperty(ref _moduleContent, value);
            }
        }

        public ViewAViewModel(IRegionManager regionManager, IMessageService messageService)
            : base(regionManager)
        {
            Message = messageService.GetMessage();
            ModuleContent = "Content module";
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            ;
        }
    }
}
