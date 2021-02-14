using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using PrismBlankApp.Services.Interfaces;
using Prism;
using Prism.Ioc;
using Prism.Regions;
using PrismBlankApp.Core.Mvvm;
using PrismBlankApp.Services;

namespace PrismBlankApp.ViewModels
{
    public class ShellSettingsFlyoutViewModel : RegionViewModelBase
    {
        private ILocalizerService localizerService = null;

        public ShellSettingsFlyoutViewModel(IRegionManager regionManager, IMessageService messageService)
            : base(regionManager)
        {
            //Prism.Unity.UnityContainerExtension container = Con
            localizerService = Prism.Ioc.ContainerLocator.Container.Resolve<ILocalizerService>();

            //this.localizerService = localizerService;
            //Prism.Ioc.ContainerLocator.Container.Resolve<ILocalizerService>(ServiceNames.LocalizerService);

        }

        /// <summary>
        /// Supported languages
        /// </summary>
        public IList<CultureInfo> SupportedLanguages
        {
            get
            {
                if (localizerService != null)
                {
                    return localizerService.SupportedLanguages;
                }

                return null;
            }
        }

        /// <summary>
        /// The selected language
        /// </summary>
        public CultureInfo SelectedLanguage
        {
            get { return (localizerService != null) ? localizerService.SelectedLanguage : null; }
            set
            {
                if (value != null && value != this.localizerService.SelectedLanguage)
                {
                    if (localizerService != null)
                        this.localizerService.SelectedLanguage = value;
                }

            }
        }

    }
}
