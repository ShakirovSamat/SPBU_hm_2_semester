using CalculatorLogic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalculatorLogic.CalculatorLogic calculator = new CalculatorLogic.CalculatorLogic();
        public Form1()
        {
            InitializeComponent();
        }

        private void PluButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            Array.Reverse(input);
            double.TryParse(input[0], out double number);
            try
            {
                calculator.Calculate(number, '+');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void SubstractionButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            Array.Reverse(input);
            if (input[0] == "")
            {
                inOutLabel.Text += "-";
                return;
            }

            double.TryParse(input[0], out double number);
            try
            {
                calculator.Calculate(number, '-');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void MultiplicationButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            Array.Reverse(input);
            double.TryParse(input[0], out double number);
            try
            {
                calculator.Calculate(number, '*');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void DivisionButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            Array.Reverse(input);
            double.TryParse(input[0], out double number);
            try
            {
                calculator.Calculate(number, '/');
            }
            catch(DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void equalsButton_MouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            Array.Reverse(input);
            double.TryParse(input[0], out double number);
            try
            {
                calculator.Calculate(number, '=');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void OneButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "1";
            }
        }

        private void TwoButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "2";
            }
        }

        private void ThreeButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "3";
            }
        }

        private void FourButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "4";
            }
        }

        private void FiveButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "5";
            }
        }

        private void SixButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "6";
            }
        }

        private void SevenButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "7";
            }
        }

        private void EightButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "8";
            }
        }

        private void NineButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += "9";
            }
        }

        private void ZeroButtonMouseClick(object sender, MouseEventArgs e)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0' && input[0] != '-')
            {
                inOutLabel.Text += "0";
            }
        }
    }
}