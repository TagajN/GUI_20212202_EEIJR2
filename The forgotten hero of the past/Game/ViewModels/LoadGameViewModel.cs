using Game.Commands;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    public class LoadGameViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public LoadGameViewModel(INavigationService HomeNavigationService)
        {
            NavigateHomeCommand = new NavigateCommand(HomeNavigationService);
        }
    }
}
