using Game.Commands;
using Game.Stores;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {
        public ICommand NewGameCommand { get; }
        public ICommand LoadGameCommand { get; }
        public ICommand LeaderBoardsCommand { get; }

        public ICommand ExitCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NewGameCommand = new NavigateCommand<NewGameViewModel>(navigationStore, () => new NewGameViewModel(navigationStore));
            LoadGameCommand = new NavigateCommand<LoadGameViewModel>(navigationStore, () => new LoadGameViewModel(navigationStore));
            LeaderBoardsCommand = new NavigateCommand<LeaderBoardsViewModel>(navigationStore, () => new LeaderBoardsViewModel(navigationStore));
            ExitCommand = new RelayCommand(() => System.Environment.Exit(1));
        }
    }
}
