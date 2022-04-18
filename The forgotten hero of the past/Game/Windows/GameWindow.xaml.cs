using Game.Model;
using Game.Model.Characters;
using Game.Renderer;
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
using WpfAnimatedGif;

namespace Game.Windows
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        GameModel model;
        KnightModel playerobj = new KnightModel(100, 0, 0, 50, "Pista", 1000, 700, 400, 400);
        Display display = new Display();
        Task task2;
        public GameWindow()
        {
            InitializeComponent();
            DataContext = playerobj;

            var AnimationTimer = new DispatcherTimer();
            AnimationTimer.Tick += AnimationTimerTick;
            AnimationTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            task2 = new Task(AnimationTimer.Start);

            task2.Start();
        }

        private void Esc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                new PauseMenuWindow().ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new HeroMenuWindow().ShowDialog();
        }

        public void AnimationTimerTick(object sender, EventArgs e)
        {
            display.PlayPlayerAnimation(Player_Canvas, playerobj);

        }
    }
}
