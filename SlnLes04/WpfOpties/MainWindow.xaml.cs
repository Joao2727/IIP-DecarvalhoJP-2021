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

namespace WpfOpties
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



        private void button_check(object sender, RoutedEventArgs e)
        {
            //CHECKBOX GOOGLE
            if (ChckGoogle.IsChecked == true)
            {

                imgcheck.Visibility = Visibility.Visible;
                imgcheck.Source = new BitmapImage(new Uri("img/check.png", UriKind.Relative));
            }
            else
            {
                imgcheck.Visibility = Visibility.Hidden;

            }

            //CHECKBOX KENNIS
            if (ChckKennis.IsChecked == true) {
                imgcheck.Visibility = Visibility.Visible;
                imgcheck.Source = new BitmapImage(new Uri("img/check.png", UriKind.Relative));
            }

            //CHECKBOX ANDERE
            if (ChckAndere.IsChecked == true)
            {

                TxtBox1.Visibility = Visibility.Visible;


            }
            else
            {
                TxtBox1.Visibility = Visibility.Hidden;
            }

            

        }

      
    }
    }

