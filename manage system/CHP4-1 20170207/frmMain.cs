using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHP4_1_20170207
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnAddStu_Click(object sender, EventArgs e)
        {
            frmAddStudent FAS = new frmAddStudent();
            FAS.MdiParent = this;
            FAS.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void tsbtnSearchByName_Click(object sender, EventArgs e)
		{
			FrmSearchStudentByName FSTB = new FrmSearchStudentByName();
			FSTB.MdiParent = this;
			FSTB.Show();
		}

        private void tsmiContact_Click(object sender, EventArgs e)
        {
            FrmContactUs FCU = new FrmContactUs();
            FCU.MdiParent = this;
            FCU.Show();
        }

        private void tsbtnSearchByGrade_Click(object sender, EventArgs e)
        {
            FrmSearchStudentByGrade FSSBG = new FrmSearchStudentByGrade();
            FSSBG.MdiParent = this;
            FSSBG.Show();
        }

		private void tsbtnStuList_Click(object sender, EventArgs e)
		{
			frmStudentList FSL = new frmStudentList();
			FSL.MdiParent = this;
			FSL.Show();
		}

    }
}
