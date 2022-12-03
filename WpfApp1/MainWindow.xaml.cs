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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resDouble = rateGrivna * sumGrivna;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDouble = rateDram * sumDram;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rate4.Text);
            double Inch = 0.025;
            double resDouble = rateInch /Inch;
            resSum4.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rate5.Text);
            double Foot = 0.30;
            double resDouble = rateFoot / Foot;
            resSum5.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rate6.Text);
            double Mile = 1609.3;
            double resDouble = rateMile / Mile;
            resSum6.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate7.Text);
            double Verst = 1066.8;
            double resDouble = rateVerst / Verst;
            resSum7.Text = resDouble.ToString();
        }
    }
}
