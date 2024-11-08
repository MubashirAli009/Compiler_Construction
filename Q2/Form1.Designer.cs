namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parse = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parse
            // 
            this.parse.Location = new System.Drawing.Point(310, 290);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(124, 35);
            this.parse.TabIndex = 0;
            this.parse.Text = "button1";
            this.parse.UseVisualStyleBackColor = true;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(228, 59);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(310, 167);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(369, 26);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 3;
            this.output.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.parse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label output;
    }
}

