using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CHP4_1_20170207
{
    public class DBOperation
    {
        private const string ConStr = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Password=ok";
        SqlConnection con = new SqlConnection(ConStr);
        SqlCommand cmd = new SqlCommand();
        StringBuilder sb = new StringBuilder();

        DataSet ds = new DataSet();
        SqlDataAdapter ADP = new SqlDataAdapter();


        internal int CheckUser(string name, string pwd)
        {
            try
            {
                sb.Clear();
                sb.AppendLine("select count(*) from Admin where LoginId='"+name+"' and LoginPwd='"+pwd+"'");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                return -1;

            }
            finally
            {
                con.Close();
            }
        }

        public SqlDataReader GetAllGrade()
        {
            try
            {
                sb.Clear();
                sb.AppendLine("select GradeName from Grade");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception)
            {
                return null;
            }
        }

		public SqlDataReader GetStudentByName(string name)
		{
			try
			{
				sb.Clear();
				sb.AppendLine("select StudentNo,StudentName,Gender,GradeName from Student inner join Grade on Student.GradeId=Grade.GradeId");
				if (name!="")
				{
					sb.AppendLine("where StudentName like '%"+name+"%'");
				}
				cmd.CommandText = sb.ToString();
				cmd.Connection = con;
				con.Open();
				return cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
			catch (Exception)
			{

				return null;
			}
		}

        public SqlDataReader GetStudentInfoByStuNo(string stuNo)
        {
            try
            {
                sb.Clear();
                sb.AppendLine("select * from Student where StudentNo='" + stuNo + "'");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception)
            {

                return null;

            }

        }

        public int UpdateStudentInfo(string stuNo,string pwd, string name, string sex, int gradeId, string phone, string address, string borndate, string email)
        {
            try
            {
                sb.Clear();
                sb.AppendLine("update Student set LoginPwd='" + pwd + "',StudentName='" + name + "',Gender='" + sex + "',GradeId='" + gradeId + "',phone='" + phone + "',Address='" + address + "',borndate='" + borndate + "',Email='" + email + "'where studentNo='"+stuNo+"'");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                return -1;
            }
            finally 
            {
                con.Close();
            }

        }

        public int AddStudentInfo(string num,string pwd, string name, string sex, int gradeId, string phone, string address, string borndate, string email)
        {
            try
            {
                sb.Clear();
                sb.AppendLine("insert into Student(StudentNo,Loginpwd,StudentName,Gender,GradeId,Phone,Address,BornDate,Email) values ('"+num+"','" + pwd + "','" + name + "','" + sex + "','" + gradeId + "','" + phone + "','" + address + "','" + borndate + "','" + email + "')");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet GetGrades()
        {
            sb.Clear();
            sb.AppendLine("select * from Grade");
            cmd.CommandText = sb.ToString();
            cmd.Connection = con;

            ADP.SelectCommand = cmd;
            ADP.Fill(ds,"Grade");
            return ds;
            
        }

        public DataSet GetStudents(int gradeId)
        {
            try
            {
                sb.Clear();
                sb.AppendLine("select StudentName,Gender,BornDate from Student");
                if (gradeId!=-1)
                {
                    sb.AppendLine(" where GradeId="+gradeId);
                }
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                ADP.SelectCommand = cmd;
                if (ds.Tables["Stu"]!=null)
                {
                    ds.Tables["Stu"].Clear();
                }
                ADP.Fill(ds,"Stu");
                return ds;

            }
            catch (Exception)
            {
                return null;
            }
        }

		public DataSet GetStudentInfo()
		{
			try
			{
				sb.Clear();
				sb.AppendLine("select StudentNo,StudentName,Gender,GradeName,Phone from Student inner join Grade on Student.GradeId=Grade.GradeId");
				cmd.CommandText = sb.ToString();
				cmd.Connection = con;
				ADP.SelectCommand = cmd;
				ADP.Fill(ds,"StuInfo");
				return ds;

			}
			catch (Exception)
			{

				return null;
			}
		}
	}
}
