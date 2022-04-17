using Game.Commands;
using Game.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    public class GameViewModel : ViewModelBase
    {

        public ICommand CharacterStats { get; set; }

        public GameViewModel()
        {
            CharacterStats = new RelayCommand(() => new HeroMenuWindow().ShowDialog());
            
        }
    }
}
