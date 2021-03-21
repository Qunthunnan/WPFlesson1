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

namespace WPFlesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   

    public partial class MainWindow : Window
    {
        static double сalculateString(string expression)
        {
            return 0;
        }

        static bool сheckString(string expression) 
        {
           
            return false;
        }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void input_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                result.Text = "";
                result.Text = сalculateString(input.Text).ToString();
            }
        }
    }
}
