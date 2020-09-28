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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string op = "";

        public MainWindow()
        {
            InitializeComponent();
            btnOne.Click += BtnCalc1_Click;
            btnTwo.Click += BtnCalc2_Click;
            btnThree.Click += BtnCalc3_Click;
            btnFour.Click += BtnCalc4_Click;
            btnFive.Click += BtnCalc5_Click;
            btnSix.Click += BtnCalc6_Click;
            btnSeven.Click += BtnCalc7_Click;
            btnEight.Click += BtnCalc8_Click;
            btnNine.Click += BtnCalc9_Click;
            btnZero.Click += BtnCalc0_Click;
            btnSymbolPlus.Click += BtnPlus_Click;
            btnSymbolMinus.Click += BtnMinus_Click;
            btnSymbolDivide.Click += BtnDivide_Click;
            btnSymbolTimes.Click += BtnTimes_Click;
            btnSymbolEquals.Click += BtnEquals_Click;
            btnSymbolClear.Click += BtnClear_Click;
        }

        private void BtnCalc1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void BtnCalc2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc3_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCalc9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }


        private void BtnCalc0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            txtDisplay.Text = "+";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            txtDisplay.Text = "-";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            txtDisplay.Text = "/";
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            txtDisplay.Text = "*";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        MessageBox.Show("Do not divide by zero!");
                    }
                    else
                    {
                        txtDisplay.Text = (number1 / number2).ToString();
                    }
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            op = "";
            txtDisplay.Text = "0";
        }


    }
}
