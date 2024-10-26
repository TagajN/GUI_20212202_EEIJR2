﻿using Game.Logic.MapObjects;
using Game.Windows;
using Microsoft.Toolkit.Mvvm.Input;
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
        public event EventHandler GameOver;

        public DispatcherTimer Timer;
        public DispatcherTimer Animation;
        public ObservableCollection<Gold> GoldCoins { get; set; }
        public ObservableCollection<Rect> Platforms { get; set; }
        public ObservableCollection<Portal> Portals { get; set; }
        public ObservableCollection<Chest> Chests { get; set; }
        public ObservableCollection<Potion> Potions { get; set; }

        public Player player;
        public ObservableCollection<Enemy> Enemies { get; set; }

        public bool Win = false;
        public void Start()
        {
            InitMapObjects();
            MapCreator();
            GameTimer();
            AnimationTimer();

            player.Health = 100;
            player.Damage = 50;
            player.Speed = 20;
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
            Portals = new ObservableCollection<Portal>();
            Chests = new ObservableCollection<Chest>();
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
                Portal.PlayPortalAnimation(Portals, player);
                Chest.PlayChestAnimation(Chests, player);
                Potion.PlayPotionAnimation(Potions, player);
                Enemy.PlayEnemyAnimation(player, Enemies, Platforms);
                Potion.PlayPotionAnimation(Potions, player);
                Enemy.Follow(player, Enemies, Platforms);
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
                CollisionDetection.CollisionDetection.ChestCollision(player, Chests);
                if (CollisionDetection.CollisionDetection.PortalCollision(player, Portals))
                {
                    Win = true;
                    GameOver?.Invoke(this, null);
                    Animation.Stop();
                    Timer.Stop();
                }
                if (player.PlayerDead())
                {
                    GameOver?.Invoke(this, null);
                    Animation.Stop();
                    Timer.Stop();
                }

                
            });
        }

        public void MapCreator()
        {
            this.Dispatcher.Invoke(() =>
            {
                Map.Map.Load(Platforms, GoldCoins, Potions, Enemies, Portals, Chests);
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
            string output = DateTime.Now.ToString().Replace(" ", string.Empty) + " " + player.Gold.ToString() + " " + player.KillCounter.ToString() + " " + Math.Round(player.X / 28500 * 100);
            File.AppendAllText("score.txt", output + Environment.NewLine);
        }

    }
}
