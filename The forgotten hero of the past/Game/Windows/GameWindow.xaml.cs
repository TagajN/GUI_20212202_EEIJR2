﻿using Game.Logic;
using Game.Logic.Background;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Game.Windows
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private GameLogic logic = new GameLogic();
        PauseMenuWindow pauseMenuWindow;

        public GameWindow()
        {
            
            DataContext = logic;
            logic.Start();

            KeyDown += logic.player.Jump;
            KeyUp += logic.player.JumpDown;
            logic.player.Moved += OnMoved;

            InitializeComponent();

            Player.DataContext = logic.player;

        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            logic.player.KeyDown(sender, e);
            if (logic.Pause(e))
            {
                logic.SaveScore();
                pauseMenuWindow = new PauseMenuWindow();
                pauseMenuWindow.ShowDialog();
                if (!pauseMenuWindow.IsVisible)
                {
                    logic.Resume();
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            logic.player.KeyUp(sender, e);

        }

        private void OnMoved(object sender, double x)
        {
            SViewer.ScrollToHorizontalOffset(x - BackgroundAnimation.leftOffset);

            BackgroundAnimation.Move(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, 2);

            BackgroundAnimation.UpdateRight(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, BackgroundAnimation.leftOffset);

            BackgroundAnimation.UpdateLeft(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, BackgroundAnimation.rightOffset);
        }

    }
}
