using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GoodMethod;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class JhGoodsForm : Form
    {
        public JhGoodsForm()
        {
            InitializeComponent();
            UpdateListView();
            
        }
        //主要使用此构造方法
        public JhGoodsForm(string EmpID):this()
        {
            //从登陆界面读取工作人员名。
            txtEmpID.Text = EmpID;
        }

        private void txtGoodsID_TextChanged(object sender, EventArgs e)
        {

        }
        //功能函数，string型转int型
        private int StringToInt(string source)
        {
            int result = 0;
            for (int i = 0; i < source.Length; i++)
                result = result * 10 + (source[i] - '0');
            return result;
        }

        //功能函数，string型转double型
        private double StringToDouble(string source)
        {
            if (source.IndexOf('.') == -1)
                return (double)StringToInt(source);
            else
            {
                double result = 0;
                int i;
                for(i=0;source[i]!='.';i++)
                {
                    result = result * 10 + (source[i] - '0');
                }
                
                int potPosition = ++i;
                for(;i<source.Length;i++)
                {
                    result = result * 10 + (source[i] - '0');
                }
                for(int j=0;j<source.Length-potPosition;j++)
                {
                    result /= 10;
                }
                return result;
            }
        }
        //功能函数，执行数据库插入语句，同时会检查输入是否正确。
        private void InsertIntoSql()
        {
            if(!InfoCheck())
            {
                MessageBox.Show("信息错误:信息空缺或错误！");
                return;
            }
            SqlConnection sqlConnection = new GetSqlConnection().GetCon();//连接数据库

            string sql = "Insert into dbo.tb_JhGoodsInfo(GoodsID,EmpID,JhCompName,DepotName,GoodsName,GoodsNum,GoodsUnit,GoodsJhPrice,GoodsSellPrice," +
                "GoodsNeedPrice,GoodsNoPrice,GoodsRemark,GoodsTime,Flag)values(@GoodsID,@EmpID,@JhCompName,@DepotName,@GoodsName,@GoodsNum,@GoodsUnit," +
                "@GoodsJhPrice,@GoodsSellPrice,@GoodsNeedPrice,@GoodsNoPrice,@GoodsRemark,@GoodsTime,@Flag)";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Prepare();
            sqlCommand.Parameters.AddWithValue("@GoodsID", txtGoodsID.Text);
            sqlCommand.Parameters.AddWithValue("@EmpID", txtEmpID.Text);
            sqlCommand.Parameters.AddWithValue("@JhCompName", txtJhCompName.Text);
            sqlCommand.Parameters.AddWithValue("@DepotName", txtDepotName.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsName", txtGoodsName.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsNum", StringToInt(txtGoodsNum.Text));
            sqlCommand.Parameters.AddWithValue("@GoodsUnit", txtGoodsUnit.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsJhPrice", txtGoodsJhPrice.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsSellPrice", txtGoodsSellPrice.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsNeedPrice", txtGoodsNeedPrice.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsNoPrice", txtGoodsNoPrice.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsRemark", txtGoodsRemark.Text);
            sqlCommand.Parameters.AddWithValue("@GoodsTime", txtGoodsTime.Value);
            sqlCommand.Parameters.AddWithValue("@Flag", 0);
            try
            { int r = sqlCommand.ExecuteNonQuery(); }
            catch(SqlException)
            {
                MessageBox.Show("插入信息错误，请检查是否商品编号重复");
                //打开查询界面

            }
            sqlConnection.Close();
        }
        //功能函数，执行数据库删除语句
        private void DeleteByGoodsID()
        {
            try
            {
                SqlConnection sqlConnection = new GetSqlConnection().GetCon();//连接数据库
                string sql = "delete from dbo.tb_JhGoodsInfo where GoodsID=" + txtGoodsID.Text;
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("数据库连接失败！");
            }  
        }
        //功能函数，随着数据库语句的执行，刷新ListView
        private void UpdateListView()
        {
            listView1.Items.Clear();
            try
            {
                SqlConnection sqlConnection = new GetSqlConnection().GetCon();//连接数据库
                SqlCommand cmd = new SqlCommand("select * from dbo.tb_JhGoodsInfo", sqlConnection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem((string)dataReader["GoodsID"]);
                    item.SubItems.Add((string)dataReader["GoodsName"]);
                    item.SubItems.Add((string)dataReader["JhCompName"]);
                    item.SubItems.Add((string)dataReader["EmpID"]);
                    item.SubItems.Add((string)dataReader["DepotName"]);
                    item.SubItems.Add(dataReader["GoodsNum"].ToString());
                    item.SubItems.Add((string)dataReader["GoodsUnit"]);
                    item.SubItems.Add((string)dataReader["GoodsJhPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsSellPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsNeedPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsNoPrice"]);
                    listView1.Items.Add(item);
                }
                dataReader.Close();
                sqlConnection.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("数据库连接失败");
            }
            
        }

        //ListView选其中一行，将其数据复制到文本框中
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            txtGoodsID.Text= listView1.SelectedItems[0].Text;
            txtGoodsName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtJhCompName.Text= listView1.SelectedItems[0].SubItems[2].Text;
            txtDepotName.Text= listView1.SelectedItems[0].SubItems[3].Text;
            txtGoodsNum.Text= listView1.SelectedItems[0].SubItems[4].Text;
            txtGoodsUnit.Text= listView1.SelectedItems[0].SubItems[5].Text;
            txtGoodsJhPrice.Text= listView1.SelectedItems[0].SubItems[6].Text;
            txtGoodsSellPrice.Text= listView1.SelectedItems[0].SubItems[7].Text;
            //txtGoodsNeedPrice.Text= listView1.SelectedItems[0].SubItems[8].Text;
            txtGoodsNoPrice.Text= listView1.SelectedItems[0].SubItems[9].Text;

        }
        

        private void txtJhCompName_TextChanged(object sender, EventArgs e)
        {

        }

        //单价*数量=应付价格，随着文本框的写入自动更新应付价格
        private void txtGoodsNum_TextChanged(object sender, EventArgs e)
        {
            if (txtGoodsJhPrice.Text != "")
                SetGoodsNeedPrice();
        }

        //单价*数量=应付价格，随着文本框的写入自动更新应付价格
        private void txtGoodsJhPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtGoodsNum.Text != "")
                SetGoodsNeedPrice();
        }
        private void SetGoodsNeedPrice()//功能函数，设置应付价格
        {
            double result = StringToInt(txtGoodsNum.Text) * StringToDouble(txtGoodsJhPrice.Text);
            txtGoodsNeedPrice.Text = result.ToString();
        }
        //所有文本框中的信息检查，正确返回true
        private Boolean InfoCheck()
        {
            Boolean isRightInput = true;
            //商品编号不能为空
            if (txtGoodsID.Text == "")
                isRightInput = false;
            //商品编号必须为7为数字
            if (!GoodsIDCheck(txtGoodsID.Text))
                isRightInput = false;
            //数量必须为整数
            if (!IntegralNumberCheck(txtGoodsNum.Text))
                isRightInput = false;
            //价格必须是数
            if (!NumberCheck(txtGoodsJhPrice.Text))
                isRightInput = false;
            if (!NumberCheck(txtGoodsSellPrice.Text))
                isRightInput = false;
            if (!NumberCheck(txtGoodsNoPrice.Text))
                isRightInput = false;

            return isRightInput;
        }
        //数字检测，价格应为整数或者小数
        private Boolean NumberCheck(string source)
        {
            string pattern = @"^\d+(\.\d+)?$";
            Match mc = Regex.Match(source, pattern);
            if (mc.ToString() == "")
                return false;
            else
                return true;
        }
        //整数检测，数量应为整数
        private Boolean IntegralNumberCheck(string source)
        {
            string pattern = @"^\d+$";
            Match mc = Regex.Match(source, pattern);
            if (mc.ToString() == "")
                return false;
            else
                return true;
        }
        //商品编号检测，商品编号必须为7位数字
        private Boolean GoodsIDCheck(string source)
        {
            string pattern = @"^\d{7}$";
            Match mc = Regex.Match(source, pattern);
            if (mc.ToString() == "")
                return false;
            else
                return true;
        }

        //删除按钮
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteByGoodsID();
            UpdateListView();
        }
        //增加按钮
        private void addButton_Click(object sender, EventArgs e)
        {
            InsertIntoSql();
            UpdateListView();
        }
        //修改按钮
        private void updateButton_Click(object sender, EventArgs e)
        {
            DeleteByGoodsID();
            InsertIntoSql();
            UpdateListView();
        }
        //查询按钮
        private void queryButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection sqlConnection = new GetSqlConnection().GetCon();
            string sql = "select * from dbo.tb_JhGoodsInfo where ";
            switch (keyType.SelectedIndex)
            {
                case 0: { sql += "GoodsID LIKE \'%" + keyText.Text + "%\'"; break; }
                case 1: { sql += "GoodsName LIKE \'%" + keyText.Text + "%\'"; break; }
                case 2: { sql += "JhCompName LIKE \'%" + keyText.Text + "%\'"; break; }
                case 3: { sql += "EmpID LIKE \'%" + keyText.Text + "%\'"; break; }
                case 4: { sql += "DepotName LIKE \'%" + keyText.Text + "%\'"; break; }
                default: { break; }
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
                    item.SubItems.Add(dataReader["GoodsNum"].ToString());
                    item.SubItems.Add((string)dataReader["GoodsUnit"]);
                    item.SubItems.Add((string)dataReader["GoodsJhPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsSellPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsNeedPrice"]);
                    item.SubItems.Add((string)dataReader["GoodsNoPrice"]);
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
            catch (SqlException)
            {
                MessageBox.Show("错误！\n输入正确类型！");
            }
        }
        //退出按钮
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyType_Click(object sender, EventArgs e)
        {
            keyType.Text = keyType.SelectedText;
        }
    }
}
