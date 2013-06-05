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
    public partial class CheckOut : Form
    {
        MainMenu2 pf;

        public CheckOut(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }

        public CheckOut()
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

        private void CheckoutCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CheckoutDoneBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
