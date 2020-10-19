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

namespace WpfCheckBox02
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

        private void ChckBxYsNo_Checked(object sender, RoutedEventArgs e)
        {
            LblText.Content = "Ja, ik ben er mee eens";
        }

        private void ChckBxYsNo_Unchecked(object sender, RoutedEventArgs e)
        {
            LblText.Content = "Nee, niet mee eens";
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (ChckBxYsNo2.IsChecked == true) {
                LblText1.Content = "Ja, ik doe mee met online les";
            } else
            {

                LblText1.Content = "Neen, ik doe niet mee met online les";
            }                
        }
    }
}
