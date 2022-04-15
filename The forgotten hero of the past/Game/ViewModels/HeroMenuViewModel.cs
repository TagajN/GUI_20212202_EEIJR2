using Game.Commands;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.ViewModels
{
    public class HeroMenuViewModel : ViewModelBase
    {
        public ICommand CloseWindowCommand { get; set; }

        public HeroMenuViewModel()
        {
            CloseWindowCommand = new RelayCommand<IClosable>(this.CloseWindow);
        }

        private void CloseWindow(IClosable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
