using Game.Commands;
using Game.Stores;
using Game.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    internal class NewGameViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public NewGameViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, ()=> new HomeViewModel(navigationStore));
        }
    }
}
