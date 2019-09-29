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
	public partial class frmStudentList : Form
	{
		DBOperation DBO = new DBOperation();
		DataSet ds = new DataSet();
		public frmStudentList()
		{
			InitializeComponent();
		}

		private void frmStudentList_Load(object sender, EventArgs e)
		{
			BindDGV();
		}

		private void BindDGV()
		{
			ds = DBO.GetStudentInfo();
			if (ds!=null)
			{
				dgvStu.DataSource=ds.Tables["StuInfo"];
			}
			else
			{
				MessageBox.Show("系统异常");
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			DataView dv = new DataView(ds.Tables["StuInfo"]);
			if (tvGrade.SelectedNode.Level==1)
			{
				dv.RowFilter="GradeName='"+tvGrade.SelectedNode.Text+"'";
			}
			else if (tvGrade.SelectedNode.Level==2)
			{
				dv.RowFilter = "GradeName='" + tvGrade.SelectedNode.Parent.Text + "'and Gender='" + tvGrade.SelectedNode.Text + "'";

			}
			dv.Sort = "StudentNo desc";
			dgvStu.DataSource = dv;
		}
	}
}
