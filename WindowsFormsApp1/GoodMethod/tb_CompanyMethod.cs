using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            sqlAdd += "'" + company.strCompanyRemark + "','" + company.daReDateTime + "'," + company.intEmpFalg + ")";
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

                int row = 0;
                while (dataReader.Read())
                {
                    row = data.Rows.Add();
                    for (int i = 0; i < 4; i++)
                    {
                        data[i, row].Value = dataReader[i].ToString();
                    }
                }
                dataReader.Close();
                if (row == 0)
                {
                    for (int i = 0; i < data.RowCount; i++)
                    {
                        data[0, i].Value = "";
                        data[1, i].Value = "";
                        data[2, i].Value = "";
                        data[3, i].Value = "";
                        data[4, i].Value = "";
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
