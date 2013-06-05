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
    public partial class AddMagazine : Form
    {
        public AddMagazine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBkCopyBtn_Click(object sender, EventArgs e)
        {
            AddCopy amc = new AddCopy();
            amc.Show();
        }
    }
}
