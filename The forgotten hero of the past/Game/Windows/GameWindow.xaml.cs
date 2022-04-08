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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new HeroMenuWindow().ShowDialog();
        }
    }
}
