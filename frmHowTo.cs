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
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadFormTwo));
            t.Start();
        }

        private void ThreadFormTwo()
        {
            Application.Run(new frmSecondForm());
        }
    }
}
