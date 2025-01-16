using System;
using System.Windows.Forms;

namespace labTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method handles the event when the "Insert" button is clicked
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Check if the textboxes have valid input
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAge.Text))
            {
                MessageBox.Show("Please enter both Name and Age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add values from the textboxes to the DataGridView
            string name = textBoxName.Text;
            string age = textBoxAge.Text;

            // Add a new row with the entered data
            dataGridView1.Rows.Add(name, age);

            // Clear the textboxes for new input
            textBoxName.Clear();
            textBoxAge.Clear();
        }
    }
}
