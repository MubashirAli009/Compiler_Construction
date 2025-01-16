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

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSine = new System.Windows.Forms.Button();
            this.buttonCosine = new System.Windows.Forms.Button();
            this.buttonTangent = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.ForeColor = System.Drawing.Color.Gray;
            this.textBoxInput.Text = "Enter a number";
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(260, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxInput.Enter += new System.EventHandler(this.textBoxInput_Enter);
            this.textBoxInput.Leave += new System.EventHandler(this.textBoxInput_Leave);
            // 
            // buttonSine
            // 
            this.buttonSine.Location = new System.Drawing.Point(12, 50);
            this.buttonSine.Name = "buttonSine";
            this.buttonSine.Size = new System.Drawing.Size(60, 40);
            this.buttonSine.TabIndex = 1;
            this.buttonSine.Text = "Sine";
            this.buttonSine.UseVisualStyleBackColor = true;
            this.buttonSine.Click += new System.EventHandler(this.buttonSine_Click);
            // 
            // buttonCosine
            // 
            this.buttonCosine.Location = new System.Drawing.Point(78, 50);
            this.buttonCosine.Name = "buttonCosine";
            this.buttonCosine.Size = new System.Drawing.Size(60, 40);
            this.buttonCosine.TabIndex = 2;
            this.buttonCosine.Text = "Cosine";
            this.buttonCosine.UseVisualStyleBackColor = true;
            this.buttonCosine.Click += new System.EventHandler(this.buttonCosine_Click);
            // 
            // buttonTangent
            // 
            this.buttonTangent.Location = new System.Drawing.Point(144, 50);
            this.buttonTangent.Name = "buttonTangent";
            this.buttonTangent.Size = new System.Drawing.Size(60, 40);
            this.buttonTangent.TabIndex = 3;
            this.buttonTangent.Text = "Tangent";
            this.buttonTangent.UseVisualStyleBackColor = true;
            this.buttonTangent.Click += new System.EventHandler(this.buttonTangent_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(210, 50);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(60, 40);
            this.buttonLog.TabIndex = 4;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 96);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 40);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(144, 96);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 40);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 139);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(41, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonTangent);
            this.Controls.Add(this.buttonCosine);
            this.Controls.Add(this.buttonSine);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Scientific Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSine;
        private System.Windows.Forms.Button buttonCosine;
        private System.Windows.Forms.Button buttonTangent;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelResult;
    }
}
