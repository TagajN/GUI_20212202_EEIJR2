using Game.Logic;
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
        GameLogic logic;
        public GameWindow()
        {
            InitializeComponent();
        }

        private void Esc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                new PauseMenuWindow().ShowDialog();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic = new GameLogic();
            display.Setup(logic);

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(50);
            dt.Tick += Dt_Tick;
            dt.Start();

        }

        private void Dt_Tick(object? sender, EventArgs e)
        {
            logic.Refresh();
            display.InvalidateVisual();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new HeroMenuWindow().ShowDialog();
        }
    }
}
