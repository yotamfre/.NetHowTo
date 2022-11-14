using HowTo.Models;
using HowTo.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmExport : Form
    {
        public List<PersonsModel> Data { get; set; }

        public frmExport()
        {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e)
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

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = CurrentPath.GetDbasePath();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            this.PerformExport();
        }

        private bool ValidateForm()
        {
            if (this.txtLocation.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Directory must be selected!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.txtFileName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "FileName cannot be empty!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerformExport()
        {
            string file = this.txtLocation.Text.Trim() + "\\" + this.txtFileName.Text.Trim();

            if (this.rbText.Checked)
            {
                file = file + ".txt";
                TexFiletInputOutput.ExportDataToTextFile(Data, file);
            }
            else if (this.rbXML.Checked)
            {
                file = file + ".xml";
            }
            else if (this.rbExcel.Checked)
            {
                file = file + ".xlsx";
            }

            MessageBox.Show(this, "Export of " + file + " was successful.", TitlesModel.MessageBoxTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
