using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.Services
{
    public class ApplicationCommandsProxy : IApplicationCommands
    {
        public CompositeCommand ShowCommand
        {
            get { return ApplicationCommands.ShowFlyoutCommand; }
        }
    }

    public static class ApplicationCommands
    {
        public static CompositeCommand ShowFlyoutCommand = new CompositeCommand();
    }
}
