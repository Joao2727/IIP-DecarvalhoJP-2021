using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfAlcoho
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

        private void Sldr1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int slider1 = Convert.ToInt32(Math.Round(Sldr1.Value));
            double xx = recto1.MaxWidth = 255;
            double x = recto1.Width = +17;


            LblGlas1.Content = (slider1) + " glazen";
            recto1.Width = Sldr1.Value * Sldr2.Value * x;
            byte red = Convert.ToByte(242 - Sldr1.Value);
            byte green = Convert.ToByte(25 - Sldr1.Value);
            recto1.Fill = new SolidColorBrush(Color.FromRgb(242, 21, 21));



        }

        private void Sldr2_ValueChanged (object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int slider2 = Convert.ToInt32(Math.Round(Sldr2.Value));
            double x = recto1.Width = +17;


            LblGlas2.Content = (slider2) + " glazen";
            recto1.Width = Sldr1.Value * Sldr2.Value * x;
            byte red = Convert.ToByte(242 - Sldr2.Value);
            byte green = Convert.ToByte(25 - Sldr2.Value);
            recto1.Fill = new SolidColorBrush(Color.FromRgb(21, 242, 0));

        }

        private void Sldr3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int slider3 = Convert.ToInt32(Math.Round(Sldr3.Value));
            double x = recto1.Width = +17;


            LblGlas3.Content = (slider3) + " glazen";
            recto1.Width = Sldr3.Value * Sldr2.Value * x ;
            byte red = Convert.ToByte(242 - Sldr3.Value);
            byte green = Convert.ToByte(25 - Sldr3.Value);
            recto1.Fill = new SolidColorBrush(Color.FromRgb(21, 242, 0));
        }
    }
}
