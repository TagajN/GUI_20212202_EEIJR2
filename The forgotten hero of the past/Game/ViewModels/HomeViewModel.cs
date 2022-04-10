using Game.Commands;
using Game.Stores;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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

        private string muteButton;

        public string MuteButton
        {
            get
            {
                return muteButton;
            }
            set
            {
                SetProperty(ref muteButton, value);
                OnPropertyChanged("muteButton");
            }
        }

        public HomeViewModel(NavigationStore navigationStore)
        {
            MuteButton = "🔊";
            NewGameCommand = new NavigateCommand<NewGameViewModel>(navigationStore, () => new NewGameViewModel(navigationStore));
            LoadGameCommand = new NavigateCommand<LoadGameViewModel>(navigationStore, () => new LoadGameViewModel(navigationStore));
            LeaderBoardsCommand = new NavigateCommand<LeaderBoardsViewModel>(navigationStore, () => new LeaderBoardsViewModel(navigationStore));
            CreditsCommand = new NavigateCommand<CreditsViewModel>(navigationStore, () => new CreditsViewModel(navigationStore));
            MuteCommand = new RelayCommand(() => { 
                MainWindow.MsPlayer.PauseResume("Menu");
                if (MuteButton == "🔊")
                {
                    MuteButton = "🔇";
                }
                else
                {
                    MuteButton = "🔊";
                }
            } );
            ExitCommand = new RelayCommand(() => System.Environment.Exit(1));
        }
    }
}
