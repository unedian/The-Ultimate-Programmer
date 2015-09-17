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
    /// Interaction logic for Level.xaml
    /// </summary>
    public partial class Level : UserControl
    {
        public Level()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Grid mainMenu = (Grid)Parent;
            mainMenu.Children.Clear();
            mainMenu_Control showMainMenu = new mainMenu_Control();
            mainMenu.Children.Add(showMainMenu);
        }
    }
}
