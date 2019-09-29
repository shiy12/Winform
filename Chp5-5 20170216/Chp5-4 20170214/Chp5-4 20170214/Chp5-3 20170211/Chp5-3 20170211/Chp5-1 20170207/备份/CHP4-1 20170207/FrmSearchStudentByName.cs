using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHP4_1_20170207
{
	public partial class FrmSearchStudentByName : Form
	{
		DBOperation DBO = new DBOperation();
		public FrmSearchStudentByName()
		{
			InitializeComponent();
		}

		private void FrmSearchStudentByName_Load(object sender, EventArgs e)
		{
			BindLv();
		}

		private void BindLv()
		{
			SqlDataReader reader = DBO.GetStudentByName(txtName.Text);
			if (reader!=null)
			{
				if (reader.HasRows)
				{
					lvComputer.Items.Clear();
					while (reader.Read())
					{
						ListViewItem item = new ListViewItem(reader["StudentNo"].ToString());
						item.SubItems.Add(reader["StudentName"].ToString());
						item.SubItems.Add(reader["Gender"].ToString());
						item.SubItems.Add(reader["GradeName"].ToString());
						lvComputer.Items.Add(item);

					}
				}
				else
				{
					MessageBox.Show("查无数据");	
				}
				reader.Close();
			}
			else
			{
				MessageBox.Show("系统异常");
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			BindLv();
		}

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            string stuNo = lvComputer.SelectedItems[0].Text;
            frmAddStudent FAS = new frmAddStudent();
            FAS.stuNo = stuNo;
            FAS.MdiParent = this.ParentForm;
            FAS.Show();
        }
	}
}
