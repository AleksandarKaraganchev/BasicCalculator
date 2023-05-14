namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetButton.Click += button1_Click_1;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnumber1.Text);
            double number2 = double.Parse(txtnumber2.Text);
            double result = number1 + number2;
            txtresult.Text = result.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnumber1.Text);
            double number2 = double.Parse(txtnumber2.Text);
            double result = number1 - number2;
            txtresult.Text = result.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnumber1.Text);
            double number2 = double.Parse(txtnumber2.Text);
            double result = number1 * number2;
            txtresult.Text = result.ToString();
        }

        private void devision_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnumber1.Text);
            double number2 = double.Parse(txtnumber2.Text);
            double result = number1 / number2;
            txtresult.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnumber1.Text);
            double number2 = double.Parse(txtnumber2.Text);
            double result = Math.Pow(number1, number2);
            txtresult.Text = result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnumber1.Text = "";
            txtnumber2.Text = "";
            txtresult.Text = "";
        }
    }
}