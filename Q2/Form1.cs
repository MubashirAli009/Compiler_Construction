using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void parse_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            try
            {
                if (ParseS(input) && input.All(char.IsWhiteSpace))
                {
                    output.Text = "Accepted";
                }
                else
                {
                    output.Text = "Rejected";
                }
            }
            catch (Exception ex)
            {
                output.Text = "Error: " + ex.Message;
            }
        }

        // Parse function for S
        private bool ParseS(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseE(input.Substring(2));
            }
            return false;
        }

        private bool ParseE(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("+"))
            {
                return ParseT(input.Substring(1)) && ParseEPrime(input.Substring(1));
            }
            return true; // E can derive ε
        }

        private bool ParseEPrime(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseT(input.Substring(2)) && ParseEPrime(input.Substring(2));
            }
            return true; // E' can derive ε
        }

        private bool ParseT(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("*"))
            {
                return ParseF(input.Substring(1)) && ParseTPrime(input.Substring(1));
            }
            return true; // T can derive ε
        }

        private bool ParseTPrime(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseF(input.Substring(2)) && ParseTPrime(input.Substring(2));
            }
            return true; // T' can derive ε
        }

        private bool ParseF(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return true;
            }
            return false;
        }
    }
}
