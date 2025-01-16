namespace LabTask1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.VariableNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // VariableNameTextBox
            this.VariableNameTextBox.Location = new System.Drawing.Point(30, 30);
            this.VariableNameTextBox.Name = "VariableNameTextBox";
            this.VariableNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.VariableNameTextBox.TabIndex = 0;

            // CheckButton
            this.CheckButton.Location = new System.Drawing.Point(30, 70);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);

            // ResultLabel
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(30, 110);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(52, 17);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Result:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.VariableNameTextBox);
            this.Name = "Form1";
            this.Text = "DFA for C Variable Names";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox VariableNameTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}
