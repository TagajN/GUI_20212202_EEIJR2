using Game.Commands;
using Game.Sound;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NewGameCommand { get; }
        public ICommand LoadGameCommand { get; }
        public ICommand LeaderBoardsCommand { get; }
        public ICommand CreditsCommand { get; }
        public ICommand MuteCommand { get; set; }
        public ICommand ExitCommand { get; }

        public HomeViewModel(List<INavigationService> NavigationList)
        {
            NewGameCommand = new NavigateCommand(NavigationList.ToArray()[0]);
            LoadGameCommand = new NavigateCommand(NavigationList.ToArray()[1]);
            LeaderBoardsCommand = new NavigateCommand(NavigationList.ToArray()[2]);
            CreditsCommand = new NavigateCommand(NavigationList.ToArray()[3]);
            ExitCommand = new RelayCommand(() => System.Environment.Exit(1));
        }
    }
}
