namespace MenuSystem1
{
    partial class AddMedia
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
            this.AddDVD = new System.Windows.Forms.Button();
            this.AddBk = new System.Windows.Forms.Button();
            this.AddCD = new System.Windows.Forms.Button();
            this.AddMag = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDVD
            // 
            this.AddDVD.BackColor = System.Drawing.Color.Firebrick;
            this.AddDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDVD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDVD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddDVD.Location = new System.Drawing.Point(390, 98);
            this.AddDVD.Name = "AddDVD";
            this.AddDVD.Size = new System.Drawing.Size(152, 57);
            this.AddDVD.TabIndex = 10;
            this.AddDVD.Text = "DVD";
            this.AddDVD.UseVisualStyleBackColor = false;
            this.AddDVD.Click += new System.EventHandler(this.AddDVD_Click);
            // 
            // AddBk
            // 
            this.AddBk.BackColor = System.Drawing.Color.Firebrick;
            this.AddBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBk.Location = new System.Drawing.Point(169, 182);
            this.AddBk.Name = "AddBk";
            this.AddBk.Size = new System.Drawing.Size(152, 57);
            this.AddBk.TabIndex = 11;
            this.AddBk.Text = "Book";
            this.AddBk.UseVisualStyleBackColor = false;
            this.AddBk.Click += new System.EventHandler(this.AddBk_Click);
            // 
            // AddCD
            // 
            this.AddCD.BackColor = System.Drawing.Color.Firebrick;
            this.AddCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddCD.Location = new System.Drawing.Point(169, 98);
            this.AddCD.Name = "AddCD";
            this.AddCD.Size = new System.Drawing.Size(152, 57);
            this.AddCD.TabIndex = 12;
            this.AddCD.Text = "CD";
            this.AddCD.UseVisualStyleBackColor = false;
            this.AddCD.Click += new System.EventHandler(this.AddCD_Click);
            // 
            // AddMag
            // 
            this.AddMag.BackColor = System.Drawing.Color.Firebrick;
            this.AddMag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMag.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMag.Location = new System.Drawing.Point(390, 182);
            this.AddMag.Name = "AddMag";
            this.AddMag.Size = new System.Drawing.Size(152, 57);
            this.AddMag.TabIndex = 13;
            this.AddMag.Text = "Magazine";
            this.AddMag.UseVisualStyleBackColor = false;
            this.AddMag.Click += new System.EventHandler(this.AddMag_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(563, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 57);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose what you want to add from below";
            // 
            // AddMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(727, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddMag);
            this.Controls.Add(this.AddCD);
            this.Controls.Add(this.AddBk);
            this.Controls.Add(this.AddDVD);
            this.Name = "AddMedia";
            this.Text = "AddMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDVD;
        private System.Windows.Forms.Button AddBk;
        private System.Windows.Forms.Button AddCD;
        private System.Windows.Forms.Button AddMag;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}