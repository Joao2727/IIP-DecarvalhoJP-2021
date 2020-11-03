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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal;
        int pogingenOver = 3;


        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 10);
            Lblpogingen.Content = " Raad het getal";
        }

        private void BtnControleer_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON CONTROLEER
            pogingenOver--;
            int gok = Convert.ToInt32(TxtBoxRaden.Text);
            if (gok == getal)
            {
                Lblpogingen.Content = "Gewonnen!";
                BtnControleer.IsEnabled = false;
            }
             else if (gok > getal)
            {
                Lblpogingen.Content = $" je gok is te Hoog, Je hebt nog {pogingenOver} pogingen over";
                if (pogingenOver == 0)
                {
                    BtnControleer.IsEnabled = false;
                }

            }
            else if (gok < getal)
            {
                Lblpogingen.Content = $" je gok is te Laag, Je hebt nog {pogingenOver} pogingen over";
                if (pogingenOver == 0)
                {
                    Lblpogingen.Content = " Verloren ";
                }

            }
        }

        private void BtnRestart_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
            int gok = Convert.ToInt32(TxtBoxRaden.Text);
            BtnControleer.IsEnabled = true;
            pogingenOver = 3;
            Random rnd = new Random();
            getal = rnd.Next(1, 10);

        }
    }
    }
