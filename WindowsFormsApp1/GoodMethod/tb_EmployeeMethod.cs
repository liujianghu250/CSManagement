using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ClassInfo;

namespace WindowsFormsApp1.GoodMethod
{
    class tb_EmployeeMethod
    {
        public string tb_employeeID()
        {
            int intYear = DateTime.Now.Day;
            int intMonth = DateTime.Now.Month;
            int intDate = DateTime.Now.Year;
            int intHour = DateTime.Now.Hour;
            int intSecond = DateTime.Now.Second;
            int intMinute = DateTime.Now.Minute;
            string strTime = null;
            strTime = intYear.ToString();
            if (intMonth < 10)
            {
                strTime += "0" + intMonth.ToString();
            }
            else
            {
                strTime += intMonth.ToString();
            }
            if (intDate < 10)
            {
                strTime += "0" + intDate.ToString();
            }
            else
            {
                strTime += intDate.ToString();
            }
            if (intHour < 10)
            {
                strTime += "0" + intHour.ToString();
            }
            else
            {
                strTime += intHour.ToString();
            }
            if (intMinute < 10)
            {

                strTime += "0" + intMinute.ToString();
            }
            else
            {
                strTime += intMinute.ToString();
            }
            if (intSecond < 10)
            {

                strTime += "0" + intSecond.ToString();
            }
            else
            {
                strTime += intSecond.ToString();
            }

            return ("YG-" + strTime);



        }
        //添加
        public Boolean Add(tb_Employee employee)
        {
            MessageBox.Show(employee.daEmpBirthday.ToString());
            string sqlAdd = "insert into tb_EmpInfo values( ";
            sqlAdd += "'" + employee.intEmpID + "','" + employee.strEmpName + "','" + employee.strEmpLoginName + "',";
            sqlAdd += "'" + employee.strEmpLoginPwd + "','" + employee.intEmpSex + "','" + employee.daEmpBirthday + "',";
            sqlAdd += "'" + employee.strEmpDept + "','" + employee.strEmpPost + "','" + employee.strEmpPhone + "',";
            sqlAdd += "'" + employee.strEmpPhoneM + "','" + employee.strEmpAddress + "'," + employee.intEmpFlag + ")";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //删除
        public Boolean Delete(tb_Employee employee)
        {
            string sqlDelete = "update tb_EmpInfo  set ";
            sqlDelete += "EmpFlag='" + employee.intEmpFlag + "' where EmpID ='" + employee.intEmpID + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //修改
        public Boolean Update(tb_Employee employee)
        {
            string sqlUpdate = "update tb_EmpInfo  set ";
            sqlUpdate += "EmpName='" + employee.strEmpName + "',EmpLoginName='" +"',";
            sqlUpdate +=  "EmpSex='" + employee.intEmpSex + "',EmpBirthday='" + employee.daEmpBirthday + "',EmpDept='" + employee.strEmpDept + "',";
            sqlUpdate += "EmpPost='" + employee.strEmpPost + "',EmpPhone='" + employee.strEmpPhone + "', EmpPhoneM='" + employee.strEmpPhoneM + "',";
            sqlUpdate += "EmpAddress='" + employee.strEmpAddress + "' where EmpID = '" + employee.intEmpID + "'";

            MessageBox.Show(sqlUpdate);
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        //查询
        public Boolean Find(string name, string pwd)
        {
            string sqlSelect = "select count(*) from tb_EmpInfo where EmpLoginName ='" + name + " 'and EmpLoginPwd= '" + pwd + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                int count = (int)cmd.ExecuteScalar();
                if(count == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public Boolean Find(DataGridView data, string key = "", string keyType = "")
        {
            string sqlSelect;
            if (keyType.Length != 0)
            {
                sqlSelect = "select * from tb_EmpInfo where " + keyType + " like '%" + key + "%' and EmpFlag = 0";
            }
            else
            {
                sqlSelect = "select * from tb_EmpInfo where EmpFlag = 0";//不为空的行
            }
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                //得到表的行数
                int rowCount = 0;
                while (dataReader.Read())
                {
                    rowCount++;
                }
                dataReader.Close();

                if (rowCount != 0)
                {
                    int i = 0;
                    data.RowCount = rowCount;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            data[j, i].Value = dataReader[j].ToString();
                        }
                        i++;
                    }
                    dataReader.Close();
                }
                else
                {
                    data.RowCount = 1;
                    for (int j = 0; j < 5; j++)
                    {
                        data[j, 0].Value = "";
                    }
                }
                conn.Dispose();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
