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

namespace WpfIngredienten
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

        private void Btnmkn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_maaklijst_Click(object sender, RoutedEventArgs e)
        {
            //STRINGS
            string line = Environment.NewLine;
            string eenheid1 = Convert.ToString(Cbox1);
            string eenheid2 = Convert.ToString(Cbox2.Text);
            string eenheid3 = Convert.ToString(Cbox3.Text);
            string eenheid4 = Convert.ToString(Cbox4.Text);
            //DOUBLE
            double getalpersoon = Convert.ToDouble(Cbpersoon.Text);
            double getal1 = Convert.ToDouble(txthvl1.Text);
            double getal2 = Convert.ToDouble(txthvl2.Text);
            double getal3 = Convert.ToDouble(txthvl3.Text);
            double getal4 = Convert.ToDouble(txthvl4.Text);
            double uitkomst = getalpersoon * getal1;
            double uitkomst1 = getalpersoon * getal2;
            double uitkomst2 = getalpersoon * getal3;
            double uitkomst3 = getalpersoon * getal4;

            LblMenu.Content = "- " + Math.Round(uitkomst)+" "+ TxtIngredienten1.Text + line+
            "- " + Math.Round(uitkomst1) +" " + eenheid2 +" "+ TxtIngredienten2.Text + line+ 
            "- " + Math.Round(uitkomst2) +" " + eenheid3 +" "+ TxtIngredienten3.Text + line+ 
            "- " + Math.Round(uitkomst3) +" " + eenheid4 +" "+ TxtIngredienten4.Text + line;
            



        }
    }
}
