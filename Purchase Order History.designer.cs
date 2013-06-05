namespace MenuSystem1
{
    partial class Purchase_Order_History
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
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Past Week",
            "Past Month",
            "Past 3 Months",
            "Past 6 Months",
            "Past Year",
            "Past 2 Years",
            "Past 5 Years",
            "Genesis"});
            this.comboBox7.Location = new System.Drawing.Point(303, 18);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(240, 24);
            this.comboBox7.TabIndex = 206;
            this.comboBox7.Text = "Please Select";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(16, 21);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 16);
            this.label39.TabIndex = 205;
            this.label39.Text = "Show";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.OrderDate,
            this.Status,
            this.orderedBy,
            this.Price,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(19, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 585);
            this.dataGridView1.TabIndex = 207;
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Order ID";
            this.orderID.Name = "orderID";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 75;
            // 
            // orderedBy
            // 
            this.orderedBy.HeaderText = "Ordered By";
            this.orderedBy.Name = "orderedBy";
            // 
            // Price
            // 
            this.Price.HeaderText = "Total Price";
            this.Price.Name = "Price";
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.Width = 350;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 55);
            this.button1.TabIndex = 208;
            this.button1.Text = "View Order Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Saved",
            "Pending",
            "Complete"});
            this.comboBox1.Location = new System.Drawing.Point(68, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 24);
            this.comboBox1.TabIndex = 209;
            this.comboBox1.Text = "Please Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 210;
            this.label1.Text = "Orders from the";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 211;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Purchase_Order_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(919, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label39);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchase_Order_History";
            this.Text = "Purchase Order History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}