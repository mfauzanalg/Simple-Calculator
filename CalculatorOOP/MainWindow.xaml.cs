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

namespace CalculatorOOP
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "0";
        }
            
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "1";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "2";
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "3";
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "4";
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "5";
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "6";
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "7";
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "8";
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "9";
        }

        private void BZ_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += ".";
        }

        private void BP_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "+";
        }

        private void BM_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "-";
        }

        private void BX_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "x";
        }

        private void BD_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += ":";
        }

        private void BS_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "√";
        }

        private void BE_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += "=";
        }

        private void BO_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
