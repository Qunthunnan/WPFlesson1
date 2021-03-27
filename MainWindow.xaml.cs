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
            input.Text = "0";
        }

        Num num = new Num();
        Num num1 = new Num();
        Num num2 = new Num();
        int state = 0;
        ExpressionCalc.eOperation operation;
        ExpressionCalc expression = new ExpressionCalc();
        bool expressionView = false;

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
            if (expressionView == false)
            {
                view.Text = num.getNum().ToString() + "+";
                expressionView = true;
            }
            else
                view.Text += num.getNum().ToString() + "+";

            switch (state)
            {
                case 0:
                    num1 = num;
                    state = 1;
                    break;
                case 1:
                    state = 2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                case 2:
                    num1 = num2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                default:
                    break;
            }

            operation = ExpressionCalc.eOperation.Plus;
            num = null;
            num = new Num();
            input.Text = num.getNum().ToString();
        }

        private void equalKey_Click(object sender, RoutedEventArgs e)
        {
            switch (state)
            {
                case 1:
                    num2 = num;
                    break;
                case 2:
                    num1 = num2;
                    num2 = num;
                    break;
                default:
                    break;
            }
            expression.addOperation(num1.getNum(), num2.getNum(), operation);
            input.Text = expression.calculateExpression().ToString();
            view.Text += num.getNum().ToString() + "=";
            expressionView = false;
            num = null;
            num = new Num();
            state = 0;
            num1 = num;
            num2 = num;
            expression = null;
            expression = new ExpressionCalc();
        }

        private void dotKey_Click(object sender, RoutedEventArgs e)
        {
            if (!num.isBlockDot())
            {
                input.Text += ",";
                num.addDot();
            }
        }

        private void minusKey_Click(object sender, RoutedEventArgs e)
        {
            if (expressionView == false)
            {
                view.Text = num.getNum().ToString() + "-";
                expressionView = true;
            }
            else
                view.Text += num.getNum().ToString() + "-";

            switch (state)
            {
                case 0:
                    num1 = num;
                    state = 1;
                    break;
                case 1:
                    state = 2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                case 2:
                    num1 = num2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                default:
                    break;
            }

            operation = ExpressionCalc.eOperation.Minus;
            num = null;
            num = new Num();
            input.Text = num.getNum().ToString();
        }

        private void divideKey_Click(object sender, RoutedEventArgs e)
        {
            if (expressionView == false)
            {
                view.Text = num.getNum().ToString() + "/";
                expressionView = true;
            }
            else
                view.Text += num.getNum().ToString() + "/";

            switch (state)
            {
                case 0:
                    num1 = num;
                    state = 1;
                    break;
                case 1:
                    state = 2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                case 2:
                    num1 = num2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                default:
                    break;
            }

            operation = ExpressionCalc.eOperation.Divide;
            num = null;
            num = new Num();
            input.Text = num.getNum().ToString();
        }

        private void asteriskKey_Click(object sender, RoutedEventArgs e)
        {
            if (expressionView == false)
            {
                view.Text = num.getNum().ToString() + "*";
                expressionView = true;
            }
            else
                view.Text += num.getNum().ToString() + "*";

            switch (state)
            {
                case 0:
                    num1 = num;
                    state = 1;
                    break;
                case 1:
                    state = 2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                case 2:
                    num1 = num2;
                    num2 = num;
                    expression.addOperation(num1.getNum(), num2.getNum(), operation);
                    break;
                default:
                    break;
            }

            operation = ExpressionCalc.eOperation.Multiply;
            num = null;
            num = new Num();
            input.Text = num.getNum().ToString();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                zeroKey_Click(this, null);
            }

            if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                oneKey_Click(this, null);
            }

            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                twoKey_Click(this, null);
            }

            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                threeKey_Click(this, null);
            }

            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                fourKey_Click(this, null);
            }

            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                fiveKey_Click(this, null);
            }

            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                sixKey_Click(this, null);
            }

            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                sevenKey_Click(this, null);
            }

            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                eightKey_Click(this, null);
            }

            if (e.Key == Key.NumPad9 || e.Key == Key.D0)
            {
                nineKey_Click(this, null);
            }
        }

        private void ceKey_Click(object sender, RoutedEventArgs e)
        {
            num = null;
            num = new Num();
            input.Text = num.getNum().ToString();
        }

        private void cKey_Click(object sender, RoutedEventArgs e)
        {
            num = null;
            num = new Num();
            state = 0;
            expression = null;
            expression = new ExpressionCalc();
            input.Text = num.getNum().ToString();
            view.Text = "";
        }

        private void deleteKey_Click(object sender, RoutedEventArgs e)
        {
            num.remooveNum();
            input.Text = num.getNum().ToString();
        }
    }
}
