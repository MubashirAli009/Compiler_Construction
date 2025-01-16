using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace labTask1
{
    public partial class Form1 : Form
    {
        private const string PlaceholderText = "Enter input in this format: a && b || c";

        public Form1()
        {
            InitializeComponent();
            
            textBoxInput.Text = PlaceholderText;
            textBoxInput.ForeColor = System.Drawing.Color.Gray;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            
            string input = textBoxInput.Text;

            
            if (input == PlaceholderText)
            {
                return;
            }

            string pattern = @"(&&|\|\||!)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            listBoxResults.Items.Clear();

            foreach (Match match in matches)
            {
                listBoxResults.Items.Add(match.Value);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            listBoxResults.Items.Clear();
            textBoxInput.Text = PlaceholderText;
            textBoxInput.ForeColor = System.Drawing.Color.Gray;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxInput.Focus();
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
