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

namespace WpfSlider
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

     

        private void SldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double getal = SldVolume.Value; // value gebruiken we voor de slider.
            LblVolume.Content = "Volume : " + getal; // Volume is de tekst die we gebruiken op de label, + is de getal die word gegeven wanneer we met de slider bewegen.
        }
    }
}
