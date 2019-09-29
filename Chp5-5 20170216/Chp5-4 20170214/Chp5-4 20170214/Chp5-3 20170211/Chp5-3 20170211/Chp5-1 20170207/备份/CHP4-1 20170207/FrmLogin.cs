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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cboLoginType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool CheckInput()  
        {
            if (this.txtUserName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("必须输入用户名","提示");
                txtUserName.Focus();
                return false;
            }
            else if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("必须输入密码","提示");
                txtPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBOperation DBO = new DBOperation();
            if (CheckInput())
            {
                int result = DBO.CheckUser(txtUserName.Text, txtPwd.Text);
                if (result==1)
                {
                    MessageBox.Show("登录成功");
                }
                else if (result==0)
                {
                    MessageBox.Show("用户名或密码错误");
                }
                else
                {
                    MessageBox.Show("系统异常");
                }
            }
       
        }
 
    }
}
