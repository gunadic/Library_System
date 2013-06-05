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
    public partial class Fees : Form
    {
        MainMenu2 pf;

        public Fees(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }
        public Fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }
    }
}
