using System;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DFA function to check if a given variable name is valid
        private bool IsValidCVariable(string input)
        {
            int state = 0;

            foreach (char c in input)
            {
                switch (state)
                {
                    case 0:
                       
                        if (char.IsLetter(c) || c == '_')
                        {
                            state = 1;  
                        }
                        else
                        {
                            return false;  
                        }
                        break;
                    case 1:
                        
                        if (char.IsLetterOrDigit(c) || c == '_')
                        {
                            state = 1; 
                        }
                        else
                        {
                            return false;  
                        }
                        break;
                    default:
                        return false;
                }
            }

            // Final accepting state
            return state == 1;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string input = VariableNameTextBox.Text;
            bool isValid = IsValidCVariable(input);

            if (isValid)
            {
                ResultLabel.Text = "Accepted";
                ResultLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ResultLabel.Text = "Rejected";
                ResultLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
