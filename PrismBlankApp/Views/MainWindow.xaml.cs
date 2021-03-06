﻿using System;
using System.Collections.Generic;
using System.Windows;
using MahApps.Metro.Controls;
using Microsoft.Extensions.Logging;
using Prism.Regions;
using PrismBlankApp.Core;

namespace PrismBlankApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(IRegionManager regionManager, ILogger logger)
        {
            InitializeComponent();

            if (regionManager == null)
                return;

            SetRegionManager(regionManager, this.leftWindowCommandsRegion, RegionNames.LeftWindowCommandsRegion);
            SetRegionManager(regionManager, this.rightWindowCommandsRegion, RegionNames.RightWindowCommandsRegion);
            SetRegionManager(regionManager, this.flyoutsControlRegion, RegionNames.FlyoutRegion);

            regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegion, typeof(RightWindowCommandsView));
            regionManager.RegisterViewWithRegion(RegionNames.LeftWindowCommandsRegion, typeof(LeftWindowCommandsView));
            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(ShellSettingsFlyout));

            logger.LogInformation("MainWindow constructor.");
        }

        void SetRegionManager(IRegionManager regionManager, DependencyObject regionTarget, string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, regionManager);
        }

    }

}
