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

namespace TheUltimateProgrammer
{
    /// <summary>
    /// Interaction logic for mainMenu_Control.xaml
    /// </summary>
    public partial class mainMenu_Control : UserControl
    {
        public mainMenu_Control()
        {
            InitializeComponent();
        }

        private void quit_game_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Play_game_Click(object sender, RoutedEventArgs e)
        {
            Grid mainMenu = (Grid)Parent;
            mainMenu.Children.Clear();
            Level testLevel = new Level();
            mainMenu.Children.Add(testLevel);
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Grid mainMenu = (Grid)Parent;
            mainMenu.Children.Clear();
            About_control showAbout = new About_control();
            mainMenu.Children.Add(showAbout);
        }
    }
}
