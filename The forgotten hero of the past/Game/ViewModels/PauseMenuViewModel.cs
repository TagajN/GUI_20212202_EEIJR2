using Game.Commands;
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
    public class PauseMenuViewModel : ViewModelBase
    {
        public ICommand CloseWindowCommand { get; set; }

        public PauseMenuViewModel()
        {
            //CloseWindowCommand = new RelayCommand<IClosable>(this.CloseWindow);
            CloseWindowCommand = new RelayCommand(() => System.Environment.Exit(1));
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
