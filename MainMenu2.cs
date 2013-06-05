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
    public partial class MainMenu2 : Form
    {
        public bool LoggedOn = false;
        public ViewUser ViewUserForm;
        public Login LoginForm;
        public AddUser AddUserForm;
        public TextMessage TextMsgForm;
        public Email EmailForm;
        public Undelete UndelForm;
        public Search SearchForm;
        public Fees FeeForm;
        public NewPurchaseOrder NPOForm;
        public Purchase_Order_History POHForm;
        public CheckIn ChkInForm;
        public CheckOut ChkOutForm;
        public ViewVendor VVForm;
        public AddVendor AVForm;

        public MainMenu2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            LoginForm = new Login();

            ViewUserForm = new ViewUser(this);
            ViewUserForm.MdiParent = this;

            LoginForm = new Login(this);
            LoginForm.MdiParent = this;

            AddUserForm = new AddUser(this);
            AddUserForm.MdiParent = this;

            TextMsgForm = new TextMessage(this);
            TextMsgForm.MdiParent = this;

            EmailForm = new Email(this);
            EmailForm.MdiParent = this;

            UndelForm = new Undelete(this);
            UndelForm.MdiParent = this;

            SearchForm = new Search(this);
            SearchForm.MdiParent = this;

            FeeForm = new Fees(this);
            FeeForm.MdiParent = this;

            NPOForm = new NewPurchaseOrder(this);
            NPOForm.MdiParent = this;

            POHForm = new Purchase_Order_History(this);
            POHForm.MdiParent = this;

            ChkInForm = new CheckIn(this);
            ChkInForm.MdiParent = this;

            ChkOutForm = new CheckOut(this);
            ChkOutForm.MdiParent = this;

            VVForm = new ViewVendor(this);
            VVForm.MdiParent = this;

            AVForm = new AddVendor(this);
            AVForm.MdiParent = this;

            LoginForm.Show();
        }

        //================================================================================//
        //                                CreateParams                                    //
        //================================================================================//
        //  Purpose: Block of code to disable the close box on a form and yet control     //
        //           miniize and maximize functionality.                                  //
        //                                                                                //
        //  Written By : Dr. Thomas E. Hicks                   Environment : .NET 2005/8  //
        //        Date : 3/1/2010                                 Language : C#           //
        //================================================================================//
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ViewUserForm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPurchaseOrder npo = new NewPurchaseOrder();
            npo.Show();
        }

        private void viewPastOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order_History poh = new Purchase_Order_History();
            poh.Show();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeForm.Show();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut chkout = new CheckOut();
            chkout.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn chkin = new CheckIn();
            chkin.Show();
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVendor av = new AddVendor();
            av.Show();
        }

        private void viewVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVendor vv = new ViewVendor();
            vv.Show();
        }

        


        
    }
}
