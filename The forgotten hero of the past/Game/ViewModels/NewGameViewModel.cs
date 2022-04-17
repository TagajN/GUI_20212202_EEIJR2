using Game.Commands;
using Game.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Game.ViewModels
{
    public class NewGameViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public ICommand KnightCommand { get; set; }
        public ICommand MageCommand { get; set; }
        public ICommand WarlockCommand { get; set; }

        public NewGameViewModel(INavigationService HomeNavigationService)
        {
            NavigateHomeCommand = new NavigateCommand(HomeNavigationService);
            KnightCommand = new RelayCommand<object>((o) => { new GameWindow().Show(); ((Window)o).Close(); }, (o) => true);
            MageCommand = new RelayCommand<object>((o) => { new GameWindow().Show(); ((Window)o).Close(); }, (o) => true);
            WarlockCommand = new RelayCommand<object>((o) => { new GameWindow().Show(); ((Window)o).Close(); }, (o) => true);

        }
    }
}
