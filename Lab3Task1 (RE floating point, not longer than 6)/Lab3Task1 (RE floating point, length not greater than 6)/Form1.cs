using System.Text.RegularExpressions;

namespace Lab3Task1__RE_floating_point__length_not_greater_than_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 

        private void button1_Click(object sender, EventArgs e)
        {
            // take input from a richtextbox/textbox 
           
 String var = richTextBox1.Text;
            // split the input on the basis of space
            String[] words = var.Split(' ');
            // Regular Expression for variables
            Regex regex1 = new Regex(@"^-?\d{0,3}(?:\.\d{1,3})?$");

            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);

                if (match1.Success)
                {
                    richTextBox2.Text += words[i] + " ";
                }

                else
                {
                    // MessageBox.Show("invalid " + words[i]);
                }
            }
        }
    }
}