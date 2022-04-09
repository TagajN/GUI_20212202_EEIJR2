using Game.Stores;
using Game.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Commands
{
    public class NavigateCommand<ViewModel> : CommandBase
        where ViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<ViewModel> createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModel> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel =  createViewModel;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
