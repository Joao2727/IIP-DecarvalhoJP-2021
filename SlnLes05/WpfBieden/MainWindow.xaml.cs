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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //GLOBALE VARIABLE
        int Hoogstebod = 0;
        string Hoogstebieder;

        public MainWindow()
        {
            InitializeComponent();

            //Er is nog geen bod uitgebracht. 
            Lblbiedingen.Content = " Er is nog geen bod uitgebracht."; 
        }

        private void BtnBod_Click(object sender, RoutedEventArgs e)
        {   
            int getal = Convert.ToInt32(TxtboxBod.Text); // conversie


            if (getal > Hoogstebod) //ALS GETAL GROTER IS DAN DE HOOGSTE BOD.
            {
                //HOOGSTE BIEDER
                Hoogstebod = getal;

                Hoogstebieder = TxtboxNaam.Text;
                Lblbiedingen.Content = ($" { Hoogstebieder } heeft met {getal}€ nu het hoogste bod!");
            }
            else
            {

                Lblbiedingen.Content = ($" Sorry, { Hoogstebieder} heeft momenteel het hoogste bod met {Hoogstebod}€ .");

            }
        }
    }
}
