namespace MenuSystem1
{
    partial class TextMessage
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TextMessageTxt = new System.Windows.Forms.ListBox();
            this.TextMessageNum = new System.Windows.Forms.TextBox();
            this.TextMessageNumLabel = new System.Windows.Forms.Label();
            this.TextMessageCarrier = new System.Windows.Forms.Label();
            this.TextMessageCarrierCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(449, 153);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 14;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(71, 153);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TextMessageTxt
            // 
            this.TextMessageTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMessageTxt.FormattingEnabled = true;
            this.TextMessageTxt.ItemHeight = 16;
            this.TextMessageTxt.Location = new System.Drawing.Point(71, 47);
            this.TextMessageTxt.Name = "TextMessageTxt";
            this.TextMessageTxt.Size = new System.Drawing.Size(453, 100);
            this.TextMessageTxt.TabIndex = 12;
            // 
            // TextMessageNum
            // 
            this.TextMessageNum.Location = new System.Drawing.Point(71, 21);
            this.TextMessageNum.Name = "TextMessageNum";
            this.TextMessageNum.Size = new System.Drawing.Size(453, 20);
            this.TextMessageNum.TabIndex = 10;
            this.TextMessageNum.Text = "(210)123-3455";
            // 
            // TextMessageNumLabel
            // 
            this.TextMessageNumLabel.AutoSize = true;
            this.TextMessageNumLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMessageNumLabel.Location = new System.Drawing.Point(47, 23);
            this.TextMessageNumLabel.Name = "TextMessageNumLabel";
            this.TextMessageNumLabel.Size = new System.Drawing.Size(24, 16);
            this.TextMessageNumLabel.TabIndex = 8;
            this.TextMessageNumLabel.Text = "To";
            // 
            // TextMessageCarrier
            // 
            this.TextMessageCarrier.AutoSize = true;
            this.TextMessageCarrier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMessageCarrier.Location = new System.Drawing.Point(159, 156);
            this.TextMessageCarrier.Name = "TextMessageCarrier";
            this.TextMessageCarrier.Size = new System.Drawing.Size(52, 16);
            this.TextMessageCarrier.TabIndex = 15;
            this.TextMessageCarrier.Text = "Carrier";
            // 
            // TextMessageCarrierCB
            // 
            this.TextMessageCarrierCB.FormattingEnabled = true;
            this.TextMessageCarrierCB.Items.AddRange(new object[] {
            "ATT",
            "Verizon",
            "Sprint",
            "TMobile"});
            this.TextMessageCarrierCB.Location = new System.Drawing.Point(217, 155);
            this.TextMessageCarrierCB.Name = "TextMessageCarrierCB";
            this.TextMessageCarrierCB.Size = new System.Drawing.Size(121, 21);
            this.TextMessageCarrierCB.TabIndex = 16;
            // 
            // TextMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(570, 195);
            this.Controls.Add(this.TextMessageCarrierCB);
            this.Controls.Add(this.TextMessageCarrier);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TextMessageTxt);
            this.Controls.Add(this.TextMessageNum);
            this.Controls.Add(this.TextMessageNumLabel);
            this.Name = "TextMessage";
            this.Text = "TextMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ListBox TextMessageTxt;
        private System.Windows.Forms.TextBox TextMessageNum;
        private System.Windows.Forms.Label TextMessageNumLabel;
        private System.Windows.Forms.Label TextMessageCarrier;
        private System.Windows.Forms.ComboBox TextMessageCarrierCB;
    }
}