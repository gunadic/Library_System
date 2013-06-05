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
    public partial class AddUser : Form
    {
        MainMenu2 pf;

        public AddUser(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }
        public AddUser()
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

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void ViewUsersTextBtn_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void ViewUsersEmailBtn_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void ViewUsersEmailBtn2_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            TextMessage txtmsg = new TextMessage();
            txtmsg.Show();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this?");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            CheckOut chkout = new CheckOut();
            chkout.Show();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submission successful!");
        }
    }
}
