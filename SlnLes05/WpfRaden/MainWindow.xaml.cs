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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int cijfer;
            int pogingen = 3;
            Random rnd = new Random();
            cijfer = rnd.Next(1, 10);
            Lblpogingen.Content = " geen bod geplaats momenteel.";
        }

        private void BtnControleer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
