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
    /// Interaction logic for PauseMenuWindow.xaml
    /// </summary>
    public partial class PauseMenuWindow : Window
    {
        public PauseMenuWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Resume(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
