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
    public partial class AddVendor : Form
    {
        MainMenu2 pf;

        public AddVendor(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }

        public AddVendor()
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
        private void button59_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            NewPurchaseOrder npo = new NewPurchaseOrder();
            npo.Show();
        }
    }
}
