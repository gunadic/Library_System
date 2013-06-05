namespace MenuSystem1
{
    partial class View_Fees
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overdue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label41 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 159;
            this.label1.Text = "Fees for User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.condition,
            this.Column3,
            this.type,
            this.ID,
            this.DueDate,
            this.ReturnedDate,
            this.Overdue,
            this.Fees});
            this.dataGridView1.Location = new System.Drawing.Point(18, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 208);
            this.dataGridView1.TabIndex = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            // 
            // condition
            // 
            this.condition.HeaderText = "Condition";
            this.condition.Name = "condition";
            this.condition.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Author/Artist";
            this.Column3.Name = "Column3";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "Item ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 50;
            // 
            // ReturnedDate
            // 
            this.ReturnedDate.HeaderText = "Returned Date";
            this.ReturnedDate.Name = "ReturnedDate";
            this.ReturnedDate.Width = 50;
            // 
            // Overdue
            // 
            this.Overdue.HeaderText = "Past Due";
            this.Overdue.Name = "Overdue";
            this.Overdue.ReadOnly = true;
            this.Overdue.Width = 50;
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            this.Fees.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 179;
            this.button1.Text = "Pay Fees";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(519, 391);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 35);
            this.button6.TabIndex = 178;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(519, 345);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 38);
            this.button7.TabIndex = 177;
            this.button7.Text = "Print Record";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(535, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 176;
            this.label10.Text = "Fees ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(594, 279);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(63, 20);
            this.textBox8.TabIndex = 175;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 305);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 114);
            this.richTextBox1.TabIndex = 174;
            this.richTextBox1.Text = "";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(15, 282);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(125, 16);
            this.label41.TabIndex = 173;
            this.label41.Text = "Transaction Notes:";
            // 
            // View_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(683, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "View_Fees";
            this.Text = "View_Fees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Overdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label41;
    }
}