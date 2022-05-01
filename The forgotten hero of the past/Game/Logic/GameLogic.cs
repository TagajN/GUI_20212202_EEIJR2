using Game.Logic.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Game.Logic
{
    class GameLogic : Window
    {
        private DispatcherTimer Timer;
        public DispatcherTimer Animation;

        public Player player = new Player();

        public void Start()
        {
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

        public void AnimationTimer()
        {
            Animation = new DispatcherTimer();
            Animation.Tick += Animation_Tick;
            Animation.Interval = new TimeSpan(0, 0, 0, 0, 60);
            Animation.IsEnabled = true;
            Animation.Start();
        }

        private void Animation_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.AnimatePlayer();
            });
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                player.InitializeMovement();
                player.UpdateGravity();
            });
        }
    }
}
