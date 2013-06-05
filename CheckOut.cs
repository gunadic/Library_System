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
        public CheckOut()
        {
            InitializeComponent();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
