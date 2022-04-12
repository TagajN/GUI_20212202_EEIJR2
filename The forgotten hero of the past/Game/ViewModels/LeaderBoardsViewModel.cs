﻿using Game.Commands;
using Game.Stores;
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

        public LeaderBoardsViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}