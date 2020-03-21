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

using Calculate;
using Parsing;

namespace CalculatorOOP
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button B0 = new Button();
            Button B1 = new Button();
            Button B2 = new Button();
            Button B3 = new Button();
            Button B4 = new Button();
            Button B5 = new Button();
            Button B6 = new Button();
            Button B7 = new Button();
            Button B8 = new Button();
            Button B9 = new Button();

            Button BE = new Button();
            Button BP = new Button();
            Button BM = new Button();
            Button BD = new Button();
            Button BX = new Button();
            Button BS = new Button();

            Button BA = new Button();
            Button BC = new Button();
            Button BR = new Button();
            Button BZ = new Button();
            Button BO = new Button();
            Button BAC = new Button();


            B0.Click += B0_Click;
            B1.Click += B1_Click;
            B2.Click += B2_Click;
            B3.Click += B3_Click;
            B4.Click += B4_Click;
            B5.Click += B5_Click;
            B6.Click += B6_Click;
            B7.Click += B7_Click;
            B8.Click += B8_Click;
            B9.Click += B9_Click;

            BE.Click += BE_Click;
            BP.Click += BP_Click;
            BM.Click += BM_Click;
            BD.Click += BD_Click;
            BX.Click += BX_Click;
            BS.Click += BS_Click;

            BA.Click += BA_Click;
            BC.Click += BC_Click;
            BR.Click += BR_Click;
            BZ.Click += BZ_Click;
            BO.Click += BO_Click;
            BAC.Click += BAC_Click;
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
            Result.Content += ",";
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
            Process.Display = Result.Content.ToString();
            Process.Lstring = Parse.makeList(Process.Display);
            Process.Hasil = Solving.solver(Process.Lstring);
            Result.Content = Process.Hasil;
        }

        private void BO_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BAC_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = "";
        }

        private void BC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BR_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
