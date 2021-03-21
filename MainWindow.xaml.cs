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
using System.Diagnostics;
using WPFLessonCalc.Models;

namespace WPFlesson1
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

       
        Num num = new Num();
        //List<operation> operations = new List<operation>();
        List<Num> nums = new List<Num>();

        private void oneKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(1);
            input.Text = num.getNum().ToString();
        }

        private void twoKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(2);
            input.Text = num.getNum().ToString();
        }

        private void threeKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(3);
            input.Text = num.getNum().ToString();
        }

        private void fourKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(4);
            input.Text = num.getNum().ToString();
        }

        private void fiveKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(5);
            input.Text = num.getNum().ToString();
        }

        private void sixKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(6);
            input.Text = num.getNum().ToString();
        }

        private void sevenKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(7);
            input.Text = num.getNum().ToString();
        }

        private void eightKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(8);
            input.Text = num.getNum().ToString();
        }

        private void nineKey_Click(object sender, RoutedEventArgs e)
        {
            num.addNum(9);
            input.Text = num.getNum().ToString();
        }

        private void zeroKey_Click(object sender, RoutedEventArgs e)
        {
            if (num.getNum() != 0)
            {
                num.addNum(0);
                input.Text = num.getNum().ToString();
            }
        }

        private void plusKey_Click(object sender, RoutedEventArgs e)
        {
            nums.Add(num);
            //operations.Add(operation.Plus);
        }

        private void equalKey_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
