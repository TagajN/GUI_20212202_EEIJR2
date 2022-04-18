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

namespace Game.Windows
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        HeroLogic logic;
        public GameWindow()
        {
            InitializeComponent();
             logic = new HeroLogic();
            display.SetupModel(logic);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            display.SetupSizes(new Size(grid.ActualWidth, grid.ActualHeight));
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            display.SetupSizes(new Size(grid.ActualWidth, grid.ActualHeight));
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                logic.Control(HeroLogic.Controls.Left);
            }
            else if (e.Key == Key.Right)
            {
                logic.Control(HeroLogic.Controls.Right);
            }
            else if(e.Key == Key.Up)
            {
                logic.Control(HeroLogic.Controls.Up);
            }
            else if (e.Key == Key.Down)
            {
                logic.Control(HeroLogic.Controls.Down);
            }
        }
    }
}
