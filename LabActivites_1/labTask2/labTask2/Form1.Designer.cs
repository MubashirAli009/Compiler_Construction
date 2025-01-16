namespace labTask2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 200);
            this.dataGridView1.TabIndex = 0;

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 1;

            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(80, 50);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 2;

            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(200, 35);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";

            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 53);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(30, 15);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age:";

            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Width = 150;

            // 
            // columnAge
            // 
            this.columnAge.HeaderText = "Age";
            this.columnAge.Name = "columnAge";
            this.columnAge.Width = 150;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataGridView Example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAge;
    }
}
