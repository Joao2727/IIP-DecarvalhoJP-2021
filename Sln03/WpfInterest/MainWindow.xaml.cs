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

namespace WpfInterest
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

        private void SldrJaar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double getal = SldrJaar.Value;
            Lbl6.Content = getal +" Jaar";

        }

        private void Btnberkenen_Click(object sender, RoutedEventArgs e)
        {
           
            float eurogetal = Convert.ToInt32(TxtBEuro.Text);
            float procentgetal = Convert.ToInt32(TxtBProcent.Text);
            float bedrag  = (eurogetal * procentgetal * 100 ) / (100 * 12) ;
            Lbluitkomst.Content = "De waarde na " + Lbl6.Content + " € " + Math.Round(bedrag, 2);
        }

        private void TxtBEuro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
