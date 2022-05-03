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
        public ObservableCollection<Enemy> Enemies { get; set; }

        public void Start()
        {
            InitMapObjects();
            MapCreator();
            GameTimer();
            AnimationTimer();

            player.Health = 350;
            player.Damage = 35;
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
            Enemies = new ObservableCollection<Enemy>();
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
                player.AnimatePlayer(Platforms, Enemies);
                Gold.PlayCoinAnimation(GoldCoins, player);
                Enemy.PlayEnemyAnimation(player, Enemies);
            });
        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.InitializeMovement(Platforms);
                player.UpdateGravity();
                CollisionDetection.CollisionDetection.PlatformCollision(player, Platforms);
                Enemy.Follow(player, Enemies);
            });
        }

        public void MapCreator()
        {
            this.Dispatcher.Invoke(() =>
            {
                Map.Map.Platforms(Platforms);
                Map.Map.Coins(GoldCoins);
                Map.Map.CreateEnemies(Enemies);
            });
        }
    }
}
