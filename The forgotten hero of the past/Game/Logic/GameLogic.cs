using Game.Logic.MapObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Game.Logic
{
    class GameLogic : Window
    {
        public DispatcherTimer Timer;
        public DispatcherTimer Animation;

        public ObservableCollection<Gold> GoldCoins { get; set; }
        public ObservableCollection<Rect> Platforms { get; set; }

        public Player player;

        public void Start()
        {
            InitMapObjects();
            MapCreator();
            GameTimer();
            AnimationTimer();

            player.Health = 100;
            player.Speed = 10;
            player.JumpStrength = -10;
        }
        public void GameTimer()
        {
            Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            Timer.IsEnabled = true;
            Timer.Start();
        }

        public void InitMapObjects()
        {
            player = new Player();
            GoldCoins = new ObservableCollection<Gold>();
            Platforms = new ObservableCollection<Rect>();
        }

        public void AnimationTimer()
        {
            Animation = new DispatcherTimer();
            Animation.Tick += Animation_Tick;
            Animation.Interval = new TimeSpan(0, 0, 0, 0, 60);
            Animation.IsEnabled = true;
            Animation.Start();
        }

        public void Animation_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.AnimatePlayer();
                Gold.PlayCoinAnimation(GoldCoins, player);
            });
        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.InitializeMovement();
                player.UpdateGravity();
            });
        }

        public void MapCreator()
        {
            this.Dispatcher.Invoke(() =>
            {
                Map.Map.Platforms(Platforms);
                Map.Map.Coins(GoldCoins);
            });
        }
    }
}
