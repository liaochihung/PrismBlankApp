using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.Modules.FlyoutTest.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : MahApps.Metro.Controls.Flyout, IFlyoutView
    {
        public ViewA()
        {
            InitializeComponent();
        }

        public string FlyoutName { get { return "FlyoutName"; } }
    }
}
