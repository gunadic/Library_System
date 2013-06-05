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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LibEmailBtn_Click(object sender, EventArgs e)
        {
            Email libemail = new Email();
            libemail.Show();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        

       
    }
}
