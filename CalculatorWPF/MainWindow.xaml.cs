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

namespace CalculatorWPF
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        int clickCount = 0;
        double Number1 = 0,
               Number2 = 0;
        bool floatN = false;
               
        string op = "";
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        #region Number Buttons
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 1) / Math.Pow(10, clickCount);
                }

                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 1;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 1) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 1;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 2) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 2;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 2) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 2;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 3) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 3;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 3) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 3;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 4) / Math.Pow(10, clickCount);
                }

                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 4;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 4) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 4;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {

                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 5) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 5;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 5) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 5;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 6) / Math.Pow(10, clickCount);
                }

                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 6;
                }
                TextDisplay.Text = Number1.ToString();

            }

            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 6) / Math.Pow(10, clickCount);

                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 6;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 7) / Math.Pow(10, clickCount);
                }

                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 7;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 7) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 7;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {

                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 8) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 8;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 8) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 8;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 9) / Math.Pow(10, clickCount);
                }

                else if (floatN == false)
                {
                    Number1 = (Number1 * 10) + 9;

                }
                TextDisplay.Text = Number1.ToString();

            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 9) / Math.Pow(10, clickCount);
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 9;

                }


                TextDisplay.Text = Number2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number1 = ((Math.Pow(10, clickCount) * Number1) + 0) / Math.Pow(10, clickCount);
                    if (Number1.ToString().Contains(","))
                    {
                        TextDisplay.Text = Number1.ToString() + "0";
                    }
                    else
                        TextDisplay.Text = Number1.ToString() + ",0";

                }
                else if (floatN == false)
                {
                    Number1 = (Number1 * 10);
                    TextDisplay.Text = Number1.ToString();
                }


            }
            else
            {
                if (floatN == true)
                {
                    clickCount++;
                    Number2 = ((Math.Pow(10, clickCount) * Number2) + 0) / Math.Pow(10, clickCount);

                    if (Number2.ToString().Contains(","))
                    {
                        TextDisplay.Text = Number2.ToString() + "0";
                    }
                    else
                        TextDisplay.Text = Number2.ToString() + ",0";
                }
                else if (floatN == false)
                {
                    Number2 = (Number2 * 10) + 0;
                    TextDisplay.Text = Number2.ToString();
                }

            }
        }
        #endregion

        #region Operations
        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            TextDisplay.Text = "0";
            OperatorDisplay.Text = Number1 + op;
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";

        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            TextDisplay.Text = "0";
            OperatorDisplay.Text = Number1 + op;
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";
        }

        private void BtnS_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            TextDisplay.Text = "0";
            OperatorDisplay.Text = Number1 + op;
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";
        }

        private void BtnM_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            TextDisplay.Text = "0";
            OperatorDisplay.Text = Number1 + "x";
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";
        }
        #endregion

        #region Other Buttons
        private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";
            if (op=="")
            {
                Number1 = 0;
            }
            else
            {
                Number2 = 0;

            }
            TextDisplay.Text = "0";
        }

        private void BtnE_Click(object sender, RoutedEventArgs e)
        {
            OperatorDisplay.Text = "";
            OnOffDisplay.Text = "";
            switch(op)
            {
                case "+":
                    TextDisplay.Text = (Number1 + Number2).ToString();
                    break;

                case "-":
                    TextDisplay.Text = (Number1 - Number2).ToString();
                    break;
                case "*":
                    TextDisplay.Text = (Number1 * Number2).ToString();
                    break;
                case "/":
                    TextDisplay.Text = (Number1/Number2).ToString();
                    break;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TextDisplay.Text = "0";
            Number2 = 0;
            Number1 = 0;
            op = "";
            OperatorDisplay.Text ="";
            floatN = false;
            clickCount = 0;
            OnOffDisplay.Text = "";

        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Number1 *= -1;
                TextDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 *=-1;
                TextDisplay.Text = Number2.ToString();
            }

            if(floatN==false)
            {
                OnOffDisplay.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            floatN = true;
                OnOffDisplay.Text = "Decimal P.: Active";
        }
            
    }
    #endregion
}
