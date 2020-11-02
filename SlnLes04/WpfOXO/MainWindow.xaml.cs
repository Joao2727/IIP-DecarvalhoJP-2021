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

namespace WpfOXO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //PROGRAMMA VOOR HEEL DE HEEL DE WINDWOW,  BOOL SPELER 1 = X || SPELER 2 = O : 
        bool Speler1 = true;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            

            Button button = (Button)sender;

            

            if (Speler1)
            {
                //SPELER 1
                button.Content = "X";
                
            }
            else {
                //SPELER 2
                button.Content = "O";
            }

            Speler1 = !Speler1;

            if (Btn1.Content == "X" && Btn2.Content == "X" && Btn3.Content == "X"
               || Btn4.Content == "X" && Btn5.Content == "X" && Btn6.Content == "X"
               || Btn7.Content == "X" && Btn9.Content == "X" && Btn8.Content == "X"
               || Btn1.Content == "X" && Btn4.Content == "X" && Btn7.Content == "X"
               || Btn2.Content == "X" && Btn5.Content == "X" && Btn8.Content == "X"
               || Btn3.Content == "X" && Btn6.Content == "X" && Btn9.Content == "X"
               || Btn1.Content == "X" && Btn5.Content == "X" && Btn9.Content == "X"
               || Btn3.Content == "X" && Btn5.Content == "X" && Btn7.Content == "X"

                )
            {
                LblWin.Content = "Speler 1 heeft gewonnen";

            } else if (Btn1.Content == "O" && Btn2.Content == "O" && Btn3.Content == "O"
               || Btn4.Content == "O" && Btn5.Content == "O" && Btn6.Content == "O"
               || Btn7.Content == "O" && Btn9.Content == "O" && Btn8.Content == "O"
               || Btn1.Content == "O" && Btn4.Content == "O" && Btn7.Content == "O"
               || Btn2.Content == "O" && Btn5.Content == "O" && Btn8.Content == "O"
               || Btn3.Content == "O" && Btn6.Content == "O" && Btn9.Content == "O"
               || Btn1.Content == "O" && Btn5.Content == "O" && Btn9.Content == "O"
               || Btn3.Content == "O" && Btn5.Content == "O" && Btn7.Content == "O") {

                LblWin.Content = "Speler 2 heeft gewonnen";
            }
        }

        
       
    }

    
}
