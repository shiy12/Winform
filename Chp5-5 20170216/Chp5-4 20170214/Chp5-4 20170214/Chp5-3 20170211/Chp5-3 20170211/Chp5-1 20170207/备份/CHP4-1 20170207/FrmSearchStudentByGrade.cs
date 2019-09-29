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
    public partial class FrmSearchStudentByGrade : Form
    {
        DBOperation DBO = new DBOperation();
        public FrmSearchStudentByGrade()
        {
            InitializeComponent();
        }

        private void FrmSearchStudentByGrade_Load(object sender, EventArgs e)
        {
            BindCBO();
            BindDGV();
        }

        private void BindDGV()
        {
            int gradeId = Convert.ToInt32(cboGrade.SelectedValue);
            DataSet ds = DBO.GetStudents(gradeId);
            if (ds!=null)
            {
                dgvStudent.DataSource = ds.Tables["Stu"];
            }
            else
            {
                MessageBox.Show("系统异常");
            }
        }

        private void BindCBO()
        {
            DataSet ds = DBO.GetGrades();
            if (ds!=null)
            {
                DataRow newRow = ds.Tables["Grade"].NewRow();
                newRow["GradeId"] = -1;
                newRow["GradeName"] = "----请选择----";
                ds.Tables["Grade"].Rows.InsertAt(newRow,0);

                cboGrade.DataSource = ds.Tables["Grade"];
                cboGrade.DisplayMember = "GradeName";
                cboGrade.ValueMember = "GradeId";

            }
            else
            {
                MessageBox.Show("系统异常");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDGV();
        }
    }
}
