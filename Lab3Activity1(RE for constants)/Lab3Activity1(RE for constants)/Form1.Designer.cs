namespace Lab3Activity1_RE_for_constants_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(113, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(157, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(329, 90);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(166, 96);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(213, 253);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}