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

namespace _4thMeet
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private float firstNumber, secondNumber;
        private int operators = -1;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("0");
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("1");
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("2");
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("3");
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("4");
        }

        private void BtnFive_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("5");
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("6");
        }

        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("7");
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("8");
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("9");
        }

        private void Add_Number(string _number)
        {
            if (Show.Text == "0")
                Show.Text = "";
            Show.Text = Show.Text + _number;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(0);
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(1);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(2);
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(3);
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(Show.Text);
            Show.Text = "0";
            operators = _operator;
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f;
            secondNumber = Convert.ToSingle(Show.Text);

            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            Show.Text = string.Format("{0:0.##########}", finalResults);

            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (Show.Text.IndexOf(".") == -1)
                Show.Text = Show.Text + ".";
        }   

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Show.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void BtnPercent_Click(object sender, RoutedEventArgs e)
        {
            double result;
            if (Show.Text.Length > 0)
            {
                if (double.TryParse(Show.Text, out result) == true)
                {
                    Show.Text = string.Format("{0:0.####}", result / 100);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (Show.Text.Length > 1)
            {
                Show.Text = Show.Text.Substring(0, Show.Text.Length - 1);
            }
            else if (Show.Text.Length == 1)
            {
                Show.Text = "0";
            }
        }
    }
}
