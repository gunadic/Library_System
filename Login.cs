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
    public partial class Login : Form
    {
        MainMenu2 pf;

        public Login(MainMenu2 Parent)
        {
            InitializeComponent();
            pf = Parent;
        }
        public Login()
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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook addBk = new AddBook();
            addBk.Show();
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

        private void AddMag_Click(object sender, EventArgs e)
        {
            AddMagazine addmag = new AddMagazine();
            addmag.Show();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Student addSt = new Student();
            addSt.Show();
        }

        private void Addteacher_Click(object sender, EventArgs e)
        {
            Faculty addFac = new Faculty();
            addFac.Show();
        }

        private void AddLib_Click(object sender, EventArgs e)
        {
            Librarian addLib = new Librarian();
            addLib.Show();
        }

        private void AddVendor_Click(object sender, EventArgs e)
        {
            Vendor addVen = new Vendor();
            addVen.Show();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrderBk_Click(object sender, EventArgs e)
        {
            OrderBook OrdBk = new OrderBook();
            OrdBk.Show();
        }

        private void OrderCD_Click(object sender, EventArgs e)
        {
            OrderCD OrdCd = new OrderCD();
            OrdCd.Show();
        }

        private void OrderDVD_Click(object sender, EventArgs e)
        {
            OrderDVD OrdDvd = new OrderDVD();
            OrdDvd.Show();
        }

        private void OrderMag_Click(object sender, EventArgs e)
        {
            OrderMagazine OrdMag = new OrderMagazine();
            OrdMag.Show();
        }

        private void ChkOutBk_Click(object sender, EventArgs e)
        {
            CheckOut COB = new CheckOut();
            COB.Show();
        }

        private void ChkOutCD_Click(object sender, EventArgs e)
        {
            CheckOut COCD = new CheckOut();
            COCD.Show();
        }

        private void CkOutDVD_Click(object sender, EventArgs e)
        {
            CheckOut CODVD = new CheckOut();
            CODVD.Show();
        }

        private void CkOutMag_Click(object sender, EventArgs e)
        {
            CheckOut COMag = new CheckOut();
            COMag.Show();
        }

        private void PayFee_Click(object sender, EventArgs e)
        {
            Fees fee = new Fees();
            fee.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchMedia smed = new SearchMedia();
            smed.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentReport srep = new StudentReport();
            srep.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacultyReport frep = new FacultyReport();
            frep.Show();
        }

        private void librarianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LibrarianReport lrep = new LibrarianReport();
            lrep.Show();
        }

        private void vendorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VendorReport vrep = new VendorReport();
            vrep.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentReport srep = new StudentReport();
            srep.Show();
        }

        
        private void reportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorReport vrep = new VendorReport();
            vrep.Show();
        }

        private void studentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentReport srep = new StudentReport();
            srep.Show();
        }

        private void teacherToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FacultyReport frep = new FacultyReport();
            frep.Show();
        }

        private void librarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrarianReport lrep = new LibrarianReport();
            lrep.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser vstud = new ViewUser();
            vstud.Show();
        }

        private void checkoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckOut chout = new CheckOut();
            chout.Show();
        }

        private void searchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            sea.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
        }

       

        
    }
}
