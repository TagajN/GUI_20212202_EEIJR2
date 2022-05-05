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
            LoadScore();
            NavigateHomeCommand = new NavigateCommand(HomeNavigationService);
        }

        public void LoadScore()
        {
            scores.Add(new Score()
            {
                Points = int.Parse(File.ReadAllText("score.txt"))
            });
        }
    }
}
