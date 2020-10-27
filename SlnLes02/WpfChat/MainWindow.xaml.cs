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


namespace WpfChat
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

        private void BtnVerz_Click(object sender, RoutedEventArgs e)
        {
            TxtBlockChat.Inlines.Add("  "+ TxtBNaam.Text + " says: " +Environment.NewLine); // Wanneer je op verzenden klikt komt er op de chat < says > toegevoegd.
            //TxtBBericht.FontWeight = FontWeights.Bold;
            TxtBlockChat.Inlines.Add("  "+ TxtBBericht.Text + Environment.NewLine);
            TxtBlockChat.Inlines.Add(Environment.NewLine); // Met deze worden er padding afstanden voorzien.

            

            TxtBNaam.Text = ""; //Wanneer de gebruiker op Verzenden klikt, dan wordden de boxen leeg gemaakt. 
            TxtBBericht.Text =""; //Wanneer de gebruiker op Verzenden klikt, dan wordden de boxen leeg gemaakt.

            
        }

        private void TxtBBericht_TextChanged(object sender, TextChangedEventArgs e)
        {
            //VERVANG WOORDEN
            String a = "a";

            a = a.Replace("shit", "fuck").Replace("****","****");
            Console.WriteLine(a);
        }
    }
}
