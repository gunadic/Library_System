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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /* Disables Exit, Enables Minimize and Maximize */
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Student users = new Student();
            users.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            AddMedia addMed = new AddMedia();
            addMed.Show();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Librarian admin = new Librarian();
            admin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
