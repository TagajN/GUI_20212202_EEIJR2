﻿using Game.Sound;
using Game.Stores;
using Game.ViewModels;
using Game.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationStore navigationStore = new NavigationStore();

        public static MusicPlayer MsPlayer = new MusicPlayer();
        public MainWindow()
        {
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
            DataContext = new MainViewModel(navigationStore);
            MsPlayer.MenuMusic();
            InitializeComponent();
        }
    }
}