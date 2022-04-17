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
    public class LeaderBoardsViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public LeaderBoardsViewModel(INavigationService HomeNavigationService)
        {
            NavigateHomeCommand = new NavigateCommand(HomeNavigationService);
        }
    }
}
