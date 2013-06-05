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
    public partial class Search : Form
    {
        MainMenu2 pf;

        public Search(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }
        public Search()
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOut cout = new CheckOut();
            cout.Show();
        }

       
    }
}
