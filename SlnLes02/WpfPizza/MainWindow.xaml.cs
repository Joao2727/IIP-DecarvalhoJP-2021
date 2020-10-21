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

namespace WpfPizza
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

        private void Rb1_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkMenu.Text = ("Tomatensaus, mozzarella, spinazie, verse tomaten, champignons, paprika, rode uien, olijven & oregano ");
            ImgBox.Source = new BitmapImage(new Uri("images/P1.png", UriKind.Relative));
        }

        private void Rb2_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkMenu.Text = ("Tomatensaus, mozzarella, rode uien, paprika, kip & barbecuesaus");
            ImgBox.Source = new BitmapImage(new Uri("images/P2.png", UriKind.Relative));
        }

        private void Rb3_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkMenu.Text = ("Crème fraiche, mozzarella, gorgonzola, emmentaler en geitenkaas");
            ImgBox.Source = new BitmapImage(new Uri("images/P3.png", UriKind.Relative));
        }
    }
}
