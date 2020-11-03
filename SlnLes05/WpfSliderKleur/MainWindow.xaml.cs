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

namespace WpfSliderKleur
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //SLIDERVALUE
            int sldvalue = Convert.ToInt32(slider1.Value);
            LblCijfer.Content = sldvalue;

            //Lebel TEKST
            LblWaarde.Content = " Geselecteerde waarde: ";


            //SLIDER COLLER EVOLUTION
            if (sldvalue == 0)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(186, 85, 211)); // COLOR MediumOrchid
            }
            else if (sldvalue > 10 && sldvalue < 20)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(30, 144, 255));  // COLOR DodgerBlue
            }
            else if (sldvalue > 20 && sldvalue < 30)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(32, 178, 170)); // COLOR LightSeaGreen
            }
            else if (sldvalue > 30 && sldvalue < 50)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0)); //COLOR YELLOW
            }
            else if (sldvalue > 50 && sldvalue < 80)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(255, 165, 0)); //COLOR ORANGE
            }
            else if (sldvalue > 90 && sldvalue < 95)
            {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(255, 69, 0)); //COLOR OrangeRed
            }
            else if (sldvalue > 95 && sldvalue < 100) {
                LblCijfer.Foreground = new SolidColorBrush(Color.FromRgb(139, 0, 0)); //COLOR DarkRed

            }
        }
    }
}
