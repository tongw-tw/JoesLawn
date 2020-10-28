// Tong Wang
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

namespace JoesLawn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        public enum services
        {
            full,
            grass,
            weed
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Full_Checked(object sender, RoutedEventArgs e)
        {
            vm.getValue(services.full);
        }

        private void Grass_Checked(object sender, RoutedEventArgs e)
        {
            vm.getValue(services.grass);
        }

        private void Weed_Checked(object sender, RoutedEventArgs e)
        {
            vm.getValue(services.weed);
        }
    }
}
