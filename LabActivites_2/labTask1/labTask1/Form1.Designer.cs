namespace labTask1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.textBoxInput.ForeColor = System.Drawing.Color.Gray; 
            this.textBoxInput.Text = "Enter input in this format: a && b || c";  
            this.textBoxInput.Location = new System.Drawing.Point(12, 30);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(260, 100);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Enter += new System.EventHandler(this.textBoxInput_Enter);
            this.textBoxInput.Leave += new System.EventHandler(this.textBoxInput_Leave);
            
            this.buttonFind.Location = new System.Drawing.Point(12, 136);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 30);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find Operators";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(12, 186);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(260, 95);
            this.listBoxResults.TabIndex = 2;
            
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(79, 13);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Enter Input Text:";
            
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 170);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(81, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Detected Operators:";
            
            this.buttonClear.Location = new System.Drawing.Point(93, 136);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            
            this.buttonEdit.Location = new System.Drawing.Point(174, 136);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 30);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Logical Operators Finder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEdit;
    }
}
