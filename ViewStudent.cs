using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuSystem1
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewUsersEmailBtn_Click(object sender, EventArgs e)
        {
            Email vsemail = new Email();
            vsemail.Show();
        }

        private void ViewUsersEmailBtn2_Click(object sender, EventArgs e)
        {
            Email vsemail = new Email();
            vsemail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextMessage txt = new TextMessage();
            txt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextMessage txt = new TextMessage();
            txt.Show();
        }

        private void ViewUsersTextBtn_Click(object sender, EventArgs e)
        {
            TextMessage txt = new TextMessage();
            txt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextMessage txt = new TextMessage();
            txt.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBtn_Click(object sender, EventArgs e)
        {
            TextMessage txt = new TextMessage();
            txt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckOut chout = new CheckOut();
            chout.Show();
        }

        

       

       
    }
}
