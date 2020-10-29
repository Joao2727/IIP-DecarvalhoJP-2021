﻿using System;
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

namespace WpfDatumkiezer
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

        private void DatePicker1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            

            string datumvolop = Datekiezer != null ? Datekiezer.SelectedDate.Value.ToString("dd MMMM yyyy") : null;
            lblText.Content = " je selecteerde " + datumvolop;




        }
    }
}
