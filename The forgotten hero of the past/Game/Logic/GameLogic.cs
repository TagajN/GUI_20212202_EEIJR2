using Game.Logic.MapObjects;
using Game.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Game.Logic
{
    class GameLogic : Window
    {
        public DispatcherTimer Timer;
        public DispatcherTimer Animation;

        public ObservableCollection<Gold> GoldCoins { get; set; }
        public ObservableCollection<Rect> Platforms { get; set; }

        public ObservableCollection<Potion> Potions { get; set; }

        public Player player;
        public ObservableCollection<Enemy> Enemies { get; set; }
        public void Start()
        {
            InitMapObjects();
            MapCreator();
            GameTimer();
            AnimationTimer();

            player.Health = 100;
            player.Damage = 200;
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
            Potions = new ObservableCollection<Potion>();
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
                Potion.PlayPotionAnimation(Potions, player);
                Enemy.PlayEnemyAnimation(player, Enemies);
                Potion.PlayPotionAnimation(Potions, player);
                Enemy.Follow(player, Enemies);
            });
        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.InitializeMovement(Platforms);
                player.UpdateGravity();
                CollisionDetection.CollisionDetection.PlatformCollision(player, Platforms);
                CollisionDetection.CollisionDetection.GoldCollision(player, GoldCoins);
                CollisionDetection.CollisionDetection.PotionCollision(player, Potions);
            });
        }

        public void MapCreator()
        {
            this.Dispatcher.Invoke(() =>
            {
                Map.Map.Platforms(Platforms);
                Map.Map.Coins(GoldCoins);
                Map.Map.CreateEnemies(Enemies);
                Map.Map.Potions(Potions);
            });
        }
        public bool Pause(KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                Animation.Stop();
                player.IsLeft = false;
                player.IsRight = false;
                return true;
            }
            return false;
        }

        public void Resume()
        {
            Animation.Start();
        }

        public void SaveScore()
        {
            string output = DateTime.Now.ToString() + " " + player.Gold.ToString() + " " + player.killcounter.ToString();
            File.AppendAllText("score.txt", output + Environment.NewLine);
        }

    }
}
