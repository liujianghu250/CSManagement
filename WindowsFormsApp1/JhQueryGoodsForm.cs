using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Method;

namespace WindowsFormsApp1
{
    public partial class JhQueryGoodsForm : Form
    {
        public JhQueryGoodsForm()
        {
            InitializeComponent();
        }
        public JhQueryGoodsForm(string queryValue):this()
        {
            txtQueryValue.Text = queryValue;
            
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection sqlConnection = new getSqlConnection().GetCon();
            string sql = "select * from dbo.tb_JhGoodsInfo where ";
            switch(txtQueryKind.SelectedIndex)
            {
                case 0: { sql += "GoodsID LIKE \'%"+txtQueryValue.Text+"%\'"; break; }
                case 1: { sql += "GoodsName LIKE \'%" + txtQueryValue.Text + "%\'"; break; }
                case 2: { sql += "JhCompName LIKE \'%" + txtQueryValue.Text + "%\'"; break; }
                case 3: { sql += "EmpID LIKE \'%" + txtQueryValue.Text + "%\'"; break; }
                case 4: { sql += "DepotName LIKE \'%" + txtQueryValue.Text + "%\'"; break; }
                default: {  break; }
            }
            try
            { 
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                
                ListViewItem item = new ListViewItem((string)dataReader["GoodsID"]);
                item.SubItems.Add((string)dataReader["GoodsName"]);
                item.SubItems.Add((string)dataReader["JhCompName"]);
                item.SubItems.Add((string)dataReader["EmpID"]);
                item.SubItems.Add((string)dataReader["DepotName"]);
                /*item.SubItems.Add(dataReader["GoodsNum"].ToString());
                item.SubItems.Add((string)dataReader["GoodsUnit"]);
                item.SubItems.Add((string)dataReader["GoodsJhPrice"]);
                item.SubItems.Add((string)dataReader["GoodsSellPrice"]);
                item.SubItems.Add((string)dataReader["GoodsNeedPrice"]);
                item.SubItems.Add((string)dataReader["GoodsNoPrice"]);*/
                listView1.Items.Add(item);
            }
                if (!dataReader.HasRows)
                {
                    ListViewItem item = new ListViewItem("无查询结果");
                    listView1.Items.Add(item);
                }
                dataReader.Close();
                sqlConnection.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("错误！\n输入正确类型！");
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtQueryKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQueryKind.Text = txtQueryKind.SelectedText;
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
