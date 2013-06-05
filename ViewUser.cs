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
    public partial class ViewUser : Form
    {
        MainMenu2 pf;

        public ViewUser(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }
        public ViewUser()
        {
            InitializeComponent();
        }

        private const int CS_NOCLOSE = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            Fees fees = new Fees();
            fees.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this?");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Undelete undel = new Undelete();
            undel.Show();
        }

        

       

       
    }
}
