using System;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        private const string PlaceholderText = "Enter a number";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSine_Click(object sender, EventArgs e)
        {
            PerformCalculation(Math.Sin, "Sine");
        }

        private void buttonCosine_Click(object sender, EventArgs e)
        {
            PerformCalculation(Math.Cos, "Cosine");
        }

        private void buttonTangent_Click(object sender, EventArgs e)
        {
            PerformCalculation(Math.Tan, "Tangent");
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(textBoxInput.Text);
                double result = Math.Log10(input);
                labelResult.Text = $"Result (Log): {result}";
            }
            catch
            {
                labelResult.Text = "Invalid input for Log.";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelResult.Text = "Result: ";
            textBoxInput.Text = PlaceholderText;
            textBoxInput.ForeColor = System.Drawing.Color.Gray;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxInput.Focus();
        }

        private void PerformCalculation(Func<double, double> func, string functionName)
        {
            try
            {
                double input = Convert.ToDouble(textBoxInput.Text);
                double result = func(input);
                labelResult.Text = $"Result ({functionName}): {result}";
            }
            catch
            {
                labelResult.Text = $"Invalid input for {functionName}.";
            }
        }

        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            if (textBoxInput.Text == PlaceholderText)
            {
                textBoxInput.Text = "";
                textBoxInput.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                textBoxInput.Text = PlaceholderText;
                textBoxInput.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
