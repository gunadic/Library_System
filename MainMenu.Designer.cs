namespace MenuSystem1
{
    partial class MainMenu
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Firebrick;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUser.Location = new System.Drawing.Point(271, 165);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(152, 57);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Firebrick;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedia.Location = new System.Drawing.Point(478, 165);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(152, 57);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(749, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdmin.Location = new System.Drawing.Point(478, 249);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(152, 57);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "Transaction";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(271, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Vendors";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose what you want to do from below";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(893, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnUser);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainMenu";
            this.Text = "Elementary School Library System Written By (Blank)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

