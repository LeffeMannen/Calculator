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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Proc_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            textDisplay.Text = "%";
        }
        //fix later
        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            textDisplay.Text = "";
        }
        //fix later
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textDisplay.Text = "";
        }
        //fix later
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                textDisplay.Text = number2.ToString();
            }
        }
        private void ParL_Click(object sender, RoutedEventArgs e)
        {
            operation = "(";
            textDisplay.Text = "(";
        }
        private void ParR_Click(object sender, RoutedEventArgs e)
        {
            operation = ")";
            textDisplay.Text = ")";
        }
        private void E_Click(object sender, RoutedEventArgs e)
        {
            operation = "e";
            textDisplay.Text = "e";
        }
        private void Pi_Click(object sender, RoutedEventArgs e)
        {
            operation = "π";
            textDisplay.Text = "π";
        }
        private void X2_Click(object sender, RoutedEventArgs e)
        {
            operation = "²";
            textDisplay.Text = "²";
        }
        private void PosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                textDisplay.Text = number2.ToString();
            }
        }
        private void Root_Click(object sender, RoutedEventArgs e)
        {
            operation = "√";
            textDisplay.Text = "√";
        }
        private void Div_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textDisplay.Text = "/";
        }
        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textDisplay.Text = "*";
        }
        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textDisplay.Text = "-";
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textDisplay.Text += "+";
        }
        //fix later
        private void Coma_Click(object sender, RoutedEventArgs e)
        {
            operation = ",";
            textDisplay.Text += ",";
        }
        //fix later
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text += "="; 
            switch (operation)
            {
                case "+":
                    textDisplay.Text += (number1 + number2).ToString();
                    break;
                case "-":
                    textDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    textDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    textDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                textDisplay.Text += number2.ToString();
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                textDisplay.Text += number2.ToString();
            }
            
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                textDisplay.Text += number2.ToString();
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                textDisplay.Text += number2.ToString();
            }
        }

    }
}
