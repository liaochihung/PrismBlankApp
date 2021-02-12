using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace PrismBlankApp.Services.Interfaces
{
    public interface IApplicationCommands
    {
        //ICommand ShowCommand { get; }
        CompositeCommand ShowCommand { get; }
    }
}
