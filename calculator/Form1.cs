namespace calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double value1, value2;
            double.TryParse(operand1, out value1);
            double.TryParse(operand2, out value2);

            if (operation == '+')
            {
                result = value1 + value2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }

            else if (operation == '-')
            {
                result = value1 - value2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }

            else if (operation == '*')
            {
                result = value1 * value2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            
            else if (operation == '/')
            {
                if (value2 != 0)
                {
                    result = value1 / value2;
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    textBox1.Text = "Can't Divide by Zero";
                }
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += ".";
            textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Substring(1);
                input = textBox1.Text;
            }

            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                textBox1.Text = "-" + textBox1.Text;
                input = textBox1.Text;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            double value;
            double.TryParse(input, out value);
            result = Math.Sqrt(value);
            textBox1.Text = result.ToString();
            input = result.ToString();

        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            double value;
            double.TryParse(input, out value);
            result = Math.ReciprocalEstimate(value);
            textBox1.Text = result.ToString();
            input = result.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            input = textBox1.Text;
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void clearentry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
        }

        private void percent_Click(object sender, EventArgs e)
        {

        }

        private void square_Click(object sender, EventArgs e)
        {
            double value;
            double.TryParse(input, out value);
            result = value * value;
            textBox1.Text = result.ToString();
            input = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
