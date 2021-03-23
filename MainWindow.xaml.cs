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
    }
}
