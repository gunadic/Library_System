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
    public partial class ViewVendor : Form
    {
        MainMenu2 pf;

        public ViewVendor(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }

        public ViewVendor()
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
    }
}
