using SetForm1PropertyFromForm2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmHowTo : Form
    {
        public frmHowTo()
        {
            InitializeComponent();
        }

        private void frmHowTo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(ThreadFormTwo));
            t.Start();
        }

        private void ThreadFormTwo()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmSecondForm());
        }

        private void btnDelegates_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
        }

        private void btnImportTextFile_Click(object sender, EventArgs e)
        {
            frmImportTextFileData importtexttiledata = new frmImportTextFileData();
            importtexttiledata.Show();
        }
    }
}
