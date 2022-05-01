using Game.ViewModels;
using MVVMEssentials.Services;
using MVVMEssentials.Stores;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Game
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore navigationStore;
        private readonly ModalNavigationStore modalNavigationStore;
        private List<INavigationService> navigationlist;

        public App()
        {
            navigationStore = new NavigationStore();
            modalNavigationStore = new ModalNavigationStore();
            navigationlist = new List<INavigationService>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService navigationService = CreateHomeNavigationService();
            navigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore, modalNavigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(navigationStore, CreateHomeViewModel);
        }

        private HomeViewModel CreateHomeViewModel()
        {
            navigationlist.Add(new NavigationService<LoadGameViewModel>(navigationStore, CreateLoadGameViewModel));
            navigationlist.Add(new NavigationService<LeaderBoardsViewModel>(navigationStore, CreateLeaderBoardsViewModel));
            navigationlist.Add(new NavigationService<CreditsViewModel>(navigationStore, CreateCreditsViewModel));
            return new HomeViewModel(navigationlist);
        }

        private CreditsViewModel CreateCreditsViewModel()
        {
            return new CreditsViewModel(CreateHomeNavigationService());
        }

        private LeaderBoardsViewModel CreateLeaderBoardsViewModel()
        {
            return new LeaderBoardsViewModel(CreateHomeNavigationService());
        }

        private LoadGameViewModel CreateLoadGameViewModel()
        {
            return new LoadGameViewModel(CreateHomeNavigationService());
        }

    }
}
