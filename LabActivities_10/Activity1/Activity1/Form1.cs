using System;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool DFA_Check(string input)
        {
            int state = 0;
            foreach (char c in input)
            {
                switch (state)
                {
                    case 0:
                        if (c == 'a')
                            state = 1;
                        else
                            return false;
                        break;
                    case 1:
                        if (c == 'b')
                            state = 2;
                        else
                            return false;
                        break;
                    case 2:
                        if (c == 'c')
                            state = 3;
                        else
                            return false;
                        break;
                    case 3:
                        if (c == 'c')
                            state = 4;
                        else
                            return false;
                        break;
                    case 4:
                        return false; // No transitions after accepting state
                }
            }
            return state == 4;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (DFA_Check(input))
            {
                lblResult.Text = "Accepted";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Rejected";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
