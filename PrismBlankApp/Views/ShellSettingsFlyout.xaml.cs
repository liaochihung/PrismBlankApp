using System.Windows.Controls;
using MahApps.Metro.Controls;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.Views
{
    /// <summary>
    /// Interaction logic for ShellSettingsFlyout
    /// </summary>
    public partial class ShellSettingsFlyout : Flyout, IFlyoutView
    {
        public ShellSettingsFlyout()
        {
            InitializeComponent();
        }

        public string FlyoutName
        {
            get { return "FlyoutRegion"; }
        }
    }
}
