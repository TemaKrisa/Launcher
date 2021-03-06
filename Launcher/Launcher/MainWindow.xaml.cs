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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Launcher.View;

namespace Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Min.IsChecked)
            {
                Panel.Width = 60;
            }
            else
            {
                Panel.Width = 220;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new Page1());
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OW());
        }
    }
}
