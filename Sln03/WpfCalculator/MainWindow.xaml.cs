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

namespace WpfCalculator
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 1
            Lblformule.Content =(Btn1.Content + "");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 2
            Lblformule.Content = (Btn2.Content + "");
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 3
            Lblformule.Content = (Btn3.Content + "");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 4
            Lblformule.Content = (Btn4.Content + "");
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 5
            Lblformule.Content = (Btn5.Content + "");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        { //BUTTON 6
            Lblformule.Content = (Btn6.Content + "");
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 7
            Lblformule.Content = (Btn7.Content + "");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 8
            Lblformule.Content = (Btn8.Content + "");
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 9
            Lblformule.Content = (Btn9.Content + "");
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON 0
            Lblformule.Content = (Btn0.Content + "");
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON PLUS
            double cijfer1 = Convert.ToDouble(LblResultaat.Content);
            double cijfer2 = Convert.ToDouble(Lblformule.Content);
            LblResultaat.Content = cijfer1 + cijfer2;
            Lblformule.Content = "";
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON MIN
            double cijfer1 = Convert.ToDouble(LblResultaat.Content);
            double cijfer2 = Convert.ToDouble(Lblformule.Content);
            LblResultaat.Content = cijfer1 - cijfer2;
            Lblformule.Content = "";
        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON MAAL
            double cijfer1 = Convert.ToDouble(LblResultaat.Content);
            double cijfer2 = Convert.ToDouble(Lblformule.Content);
            LblResultaat.Content = cijfer1 * cijfer2;
            Lblformule.Content = "";
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON CE
            Lblformule.Content = "";
            LblResultaat.Content = "0.0";
        }

        private void BtnDele_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON DELEN
            double cijfer1 = Convert.ToDouble(LblResultaat.Content);
            double cijfer2 = Convert.ToDouble(Lblformule.Content);
            LblResultaat.Content = cijfer1 / cijfer2;
            Lblformule.Content = "";
        }

        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            
            //BUTTON SIN
            double cijfer1 = Convert.ToDouble(LblResultaat.Content);
            double cijfer2 = Convert.ToDouble(Lblformule.Content);
            LblResultaat.Content = cijfer1 % cijfer2;
            Lblformule.Content = "";
        }

        private void BtnPunt_Click(object sender, RoutedEventArgs e)
        {
            // BUTTON .PUNT
            Lblformule.Content = (BtnPunt.Content + "");
        }

        private void BtnRnd_Click(object sender, RoutedEventArgs e)
        {
            //RANDOM CIJFER
            Random rnd = new Random();
            int getal = rnd.Next(1, 10);
            Lblformule.Content = (getal + "");

        }
    }
}
