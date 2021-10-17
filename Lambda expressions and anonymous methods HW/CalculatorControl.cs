using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_expressions_and_anonymous_methods_HW
{
    delegate int Calculate(int a, int b);

    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
        }

        #region lambda Expression

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var number = sender as Button;
            switch (number.Text)
            {
                case "1":
                    txtCalculatorDisplay.Text += "1";
                    break;
                case "2":
                    txtCalculatorDisplay.Text += "2";
                    break;
                case "3":
                    txtCalculatorDisplay.Text += "3";
                    break;
                case "4":
                    txtCalculatorDisplay.Text += "4";
                    break;
                case "5":
                    txtCalculatorDisplay.Text += "5";
                    break;
                case "6":
                    txtCalculatorDisplay.Text += "6";
                    break;
                case "7":
                    txtCalculatorDisplay.Text += "7";
                    break;
                case "8":
                    txtCalculatorDisplay.Text += "8";
                    break;
                case "9":
                    txtCalculatorDisplay.Text += "9";
                    break;
            }
        }

        int num1;
        int num2;
        int result;
        string mathSign;
        private void mathActions_Click(object sender, EventArgs e)
        {
            var action = sender as Button;
            Calculate Subtract = (int a, int b) => (a - b);
            Calculate Add = (int a, int b) => (a + b);
            switch (action.Text)
            {
                case "C":
                    txtCalculatorDisplay.Clear();
                    break;

                case "-":
                    num1 = int.Parse(txtCalculatorDisplay.Text);
                    txtCalculatorDisplay.Clear();
                    mathSign = "-";
                    break;

                case "+":
                    num1 = int.Parse(txtCalculatorDisplay.Text);
                    txtCalculatorDisplay.Clear();
                    mathSign = "+";
                    break;

                case "=":
                    num2 = int.Parse(txtCalculatorDisplay.Text);
                    switch (mathSign)
                    {
                        case "-":
                            result = Subtract(num1, num2);
                            break;
                        case "+":
                            result = Add(num1, num2);
                            break;
                    }
                    txtCalculatorDisplay.Clear();
                    txtCalculatorDisplay.Text = $"{result}";
                    break;
            }
        }

        #endregion

    }
}
