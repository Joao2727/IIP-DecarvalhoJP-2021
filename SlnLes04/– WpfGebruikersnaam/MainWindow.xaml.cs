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

namespace __WpfGebruikersnaam
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

        private void TxtBxNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string spaties = " ";
            //string text = "";
            //string cijfer = ("1");
            Random rnd = new Random();
            int getal;
            getal = rnd.Next(1, 10);


            //TxtBxNaam.Background = new SolidColorBrush(Colors.LightGreen);

            if (TxtBxNaam.Text == "")
            {
                Background = Brushes.White;

            }
            else if (TxtBxNaam.Text.Contains(""))
            {
                TxtBxNaam.Background = Brushes.LightGreen;
            }

            if (TxtBxNaam.Text.Contains(" "))
            {
                TxtBxNaam.Background = Brushes.Red;
                LblError.Content = " mag geen spaties bevatten";
            }
            int cijf = Convert.ToInt32(TxtBxNaam.Text);
            if (cijf == getal)
            {
                TxtBxNaam.Background = Brushes.Red;
                LblError.Content = " mag geen cijfers gebruiken";
            }
            else if (TxtBxNaam.Text == "")
            {
                TxtBxNaam.Background = Brushes.White;
                LblError.Content = "";
            }

        }
    }
}
