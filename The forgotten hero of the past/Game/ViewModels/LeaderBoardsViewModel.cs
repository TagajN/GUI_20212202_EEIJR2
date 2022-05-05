using Game.Commands;
using Game.Logic.MapObjects;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    public class LeaderBoardsViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public ObservableCollection<Score> scores { get; set; }
        public LeaderBoardsViewModel(INavigationService HomeNavigationService)
        {
            scores = new ObservableCollection<Score>();
            scores.Add(new Score()
            {
                Points = 10
            });
            scores.Add(new Score()
            {
                Points = 30
            });
            scores.Add(new Score()
            {
                Points = 50
            });
            NavigateHomeCommand = new NavigateCommand(HomeNavigationService);
        }
    }
}
