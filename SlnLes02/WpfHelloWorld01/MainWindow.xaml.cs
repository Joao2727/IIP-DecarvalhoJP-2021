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

namespace WpfHelloWorld01
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


        //OK BUTTON
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            LblText.Content = " Hallo " + TxtBxNaam.Text + " fijn dat je er bent.";

        }


        //HERSTEL BUTTON
        private void BtnHerstel_Click(object sender, RoutedEventArgs e)
        {
            LblText.Content =" Hallo, hoe is je naam ? ";
        }
    }
}
