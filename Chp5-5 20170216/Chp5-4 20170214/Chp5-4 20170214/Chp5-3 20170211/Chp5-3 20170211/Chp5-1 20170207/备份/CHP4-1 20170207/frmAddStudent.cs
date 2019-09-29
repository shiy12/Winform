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
    public partial class frmAddStudent : Form
    {
        DBOperation DBO = new DBOperation();
        public string stuNo = "";
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
            txtPwd2.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            BindGrade();
            if (stuNo=="")
            {
                cboGrade.SelectedIndex = 0;
            }
            else
            {
                txtStuNo.Text = stuNo;
                txtStuNo.Enabled = false;
                btnSave.Text = "修改";
                SqlDataReader reader = DBO.GetStudentInfoByStuNo(stuNo);
                if (reader!=null)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtPwd.Text = reader["LoginPwd"].ToString();
                            txtPwd2.Text = reader["LoginPwd"].ToString();
                            txtName.Text = reader["StudentName"].ToString();
                            txtAddress.Text=reader["Address"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtTel.Text = reader["Phone"].ToString();
                            cboGrade.SelectedIndex = Convert.ToInt32(reader["GradeId"]);
                            dtpBornDate.Value = Convert.ToDateTime(reader["borndate"]);
                            if (reader["Gender"].ToString()=="男")
                            {
                                rbtnMale.Checked = true;

                            }
                            else
                            {
                                rbtnFemale.Checked = true;
                            }
                        }
                        
                    }
                    reader.Close();

                }
                else
                {
                    MessageBox.Show("系统异常");
                }
            }
        }

        private void BindGrade()
        {
            SqlDataReader reader = DBO.GetAllGrade();
            if (reader!=null)
            {
                if (reader.HasRows)
                {
                    cboGrade.Items.Add("-----请选择-----");
                    while (reader.Read())
                    {
                        cboGrade.Items.Add(reader[0]);//或者reader["列名"]
                    }
                }
                else
                {
                    MessageBox.Show("年级无数据");
                }
                reader.Close();

            }
            else
            {
                MessageBox.Show("系统异常");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rbtnMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            int gradeId = cboGrade.SelectedIndex;
            String borndate = dtpBornDate.Value.ToString();
            if (stuNo=="")
            {
                if (CheckInput())
                {
                    int result = DBO.AddStudentInfo(txtStuNo.Text,txtPwd.Text, txtName.Text, sex, gradeId, txtTel.Text, txtAddress.Text, borndate, txtEmail.Text);
                    if (result == 1)
                    {
                        MessageBox.Show(" 添加成功");
                    }
                    else
                    {
                        MessageBox.Show("系统异常");
                    }
                }

            }
            else
            {
                if (CheckInput())
                {
                    int result = DBO.UpdateStudentInfo(stuNo, txtPwd.Text, txtName.Text, sex, gradeId, txtTel.Text, txtAddress.Text, borndate, txtEmail.Text);
                    if (result == 1)
                    {
                        MessageBox.Show(" 修改成功");
                    }
                    else
                    {
                        MessageBox.Show("系统异常");
                    }
                }
            }
        }

        private bool CheckInput()
        {
            if (txtPwd.Text=="")
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            else if (txtPwd2.Text=="")
            {
                MessageBox.Show("第二次密码也不能为空");
                return false;
            }
            else if (txtName.Text=="")
            {
                MessageBox.Show("用户名不能为空");
                return false;
            }
            else if (txtPwd.Text!=txtPwd2.Text)
            {
                MessageBox.Show("两次密码不相同");
                return false;
            }
            else if (cboGrade.SelectedIndex==0)
            {
                MessageBox.Show("请选择年级");
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
