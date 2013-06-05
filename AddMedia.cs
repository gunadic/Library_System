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
    public partial class AddMedia : Form
    {
        public AddMedia()
        {
            InitializeComponent();
        }

        private void AddCD_Click(object sender, EventArgs e)
        {
            AddCD addCd = new AddCD();
            addCd.Show();
        }

        private void AddDVD_Click(object sender, EventArgs e)
        {
            AddDVD adddvd = new AddDVD();
            adddvd.Show();
        }

        private void AddBk_Click(object sender, EventArgs e)
        {
            AddBook addBk = new AddBook();
            addBk.Show();
        }

        private void AddMag_Click(object sender, EventArgs e)
        {
            AddMagazine addMag = new AddMagazine();
            addMag.Show();
        }

        
    }
}
