﻿using Game.Logic;
using Game.Logic.Background;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
            logic.GameOver += GameOver;
            logic.Start();
            KeyDown += logic.player.Jump;
            KeyUp += logic.player.JumpDown;
            logic.player.Moved += OnMoved;

            InitializeComponent();

            Player.DataContext = logic.player;
            grid.DataContext = logic.player;

        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            logic.player.KeyDown(sender, e);
            if (logic.Pause(e))
            {
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

            BackgroundAnimation.Move(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, 1);

            BackgroundAnimation.UpdateRight(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, BackgroundAnimation.leftOffset);

            BackgroundAnimation.UpdateLeft(BackgroundImg1, BackgroundImg2, BackgroundImg3, logic.player, BackgroundAnimation.rightOffset);

            BackgroundAnimation.MoveHPBar(grid, logic.player, 500);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            logic.SaveScore();
        }

        private void GameOver(object? sender, EventArgs e)
        {

            if (logic.Win)
            {
                 var result = MessageBox.Show("Congratualation!");
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                 var result = MessageBox.Show("GAME OVER!");
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
