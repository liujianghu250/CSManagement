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
    class tb_CompanyMethod
    {
        public string tb_CompanyID()
        {

            return "testid";
        }
        //添加
        public Boolean Add(tb_Company company)
        {
            string sqlAdd = "insert into tb_Company values( ";
            sqlAdd += "'" + company.intCompanyID + "','" + company.strCompanyName + "','" + company.strCompanyDirector + "',";
            sqlAdd += "'" + company.strCompanyPhone + "','"  + company.strCompanyAddress + "','" + company.strCompanyFax + "',";
            sqlAdd += "'" + company.strCompanyRemark + "','" + company.daReDateTime + "'," + company.intEmpFlag + ")";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //删除
        public Boolean Delete(tb_Company company)
        {
            string sqlDelete = "update tb_Company  set ";
            sqlDelete += "Flag='" + company.intEmpFlag + "' where ComID ='" + company.intCompanyID + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //修改
        public Boolean Update(tb_Company company)
        {
            string sqlUpdate = "update tb_Company  set ";
            sqlUpdate += "ComName='" + company.strCompanyName + "',ComDirector='" + company.strCompanyDirector + "',";
            sqlUpdate += "ComPhone='" + company.strCompanyPhone + "',ComFax='" + company.strCompanyFax + "',ComAddress='" + company.strCompanyAddress + "',";
            sqlUpdate += "ComRemark='" + company.strCompanyRemark + "',ReDateTime='" + company.daReDateTime + "',Flag='" + company.intEmpFlag + "' where ComID ='" + company.intCompanyID + "'";
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
        public Boolean Find(DataGridView data, string key = "", string keyType = "")
        {
            string sqlSelect;
            if (keyType.Length != 0)
            {
                sqlSelect = "select * from tb_Company where " + keyType + " like '%" + key + "%' and Flag = 0";
            }
            else
            {
                sqlSelect = "select * from tb_Company where Flag = 0";//不为空的行
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

                if(rowCount != 0)
                {
                    int i = 0;
                    data.RowCount = rowCount;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for(int j = 0; j < 7; j++)
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
