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
            UpdateDataGridView();
            feedback.CreateJhGoodsForm(this);

        }

        //主要使用此构造方法
        public JhGoodsForm(string EmpID) : this()
        {
            //从登陆界面读取工作人员名。
            txtEmpID.Text = EmpID;
        }

        //反馈成员变量，用于多个窗口同时更新
        private static Feedback feedback = new Feedback();



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
                for (i = 0; source[i] != '.'; i++)
                {
                    result = result * 10 + (source[i] - '0');
                }

                int potPosition = ++i;
                for (; i < source.Length; i++)
                {
                    result = result * 10 + (source[i] - '0');
                }
                for (int j = 0; j < source.Length - potPosition; j++)
                {
                    result /= 10;
                }
                return result;
            }
        }

        //功能函数，执行数据库插入语句，同时会检查输入是否正确。
        private void InsertIntoSql()
        {
            if (!InfoCheck())
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
            catch (SqlException)
            {
                MessageBox.Show("插入信息错误，请检查是否商品编号重复");
                //打开查询界面

            }
            sqlConnection.Close();
        }
        //功能函数，执行数据库更新语句
        private void UpdateByGoodsID()
        {
            if (!InfoCheck())
            {
                MessageBox.Show("信息错误:信息空缺或错误！");
                return;
            }
            SqlConnection sqlConnection = new GetSqlConnection().GetCon();//连接数据库
            string sql = "update dbo.tb_JhGoodsInfo set ";
            sql += "EmpID ='" + txtEmpID.Text + "' ,DepotName='" + txtDepotName.Text + "',JhCompName='" + txtJhCompName.Text;
            sql += "',GoodsName='" + txtGoodsName.Text + "',GoodsNum=" + txtGoodsNum.Text + ",GoodsUnit='" + txtGoodsUnit.Text;
            sql += "',GoodsJhPrice='" + txtGoodsJhPrice.Text + "',GoodsSellPrice='" + txtGoodsSellPrice.Text;
            sql += "',GoodsNeedPrice='" + txtGoodsNeedPrice.Text + "',GoodsNoPrice='" + txtGoodsNoPrice.Text;
            sql += "',GoodsRemark='" + txtGoodsRemark.Text + "',GoodsTime='" + txtGoodsTime.Value + "',Flag=0";
            sql += " where GoodsID='" + txtGoodsID.Text + "'";


            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            { int r = sqlCommand.ExecuteNonQuery(); }
            catch (SqlException)
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
            catch (SqlException)
            {
                MessageBox.Show("数据库连接失败！");
            }
        }

        //使用lock防止多进程同时使用数据库语言
        private static readonly object objlock = new object();
        private void UseSqlCommand(int codeKind)
        {
            lock (objlock)
            {
                switch (codeKind)
                {
                    case 0: { InsertIntoSql(); break; }
                    case 1: { UpdateByGoodsID(); break; }
                    case 2: { DeleteByGoodsID(); break; }
                    default: { break; }
                }
            }
        }

        //功能函数，随着数据库语句的执行，刷新DataGridView
        private void UpdateDataGridView()
        {

            try
            {
                SqlConnection sqlConnection = new GetSqlConnection().GetCon();//连接数据库
                SqlCommand cmd = new SqlCommand("select * from dbo.tb_JhGoodsInfo", sqlConnection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataReader;
                this.dataGridView1.DataSource = bindingSource;
                dataGridView1.Columns[0].HeaderCell.Value = "商品ID";
                dataGridView1.Columns[1].HeaderCell.Value = "员工";
                dataGridView1.Columns[2].HeaderCell.Value = "进货公司";
                dataGridView1.Columns[3].HeaderCell.Value = "仓库";
                dataGridView1.Columns[4].HeaderCell.Value = "商品名称";
                dataGridView1.Columns[5].HeaderCell.Value = "数量";
                dataGridView1.Columns[6].HeaderCell.Value = "计量单位";
                dataGridView1.Columns[7].HeaderCell.Value = "进价";
                dataGridView1.Columns[8].HeaderCell.Value = "售价";
                dataGridView1.Columns[9].HeaderCell.Value = "应付价格";
                dataGridView1.Columns[10].HeaderCell.Value = "实付价格";
                dataGridView1.Columns[11].HeaderCell.Value = "备注";
                dataGridView1.Columns[12].HeaderCell.Value = "时间";


                dataReader.Close();
                sqlConnection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("数据库连接失败");
            }

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


        //增加按钮
        private void addButton_Click(object sender, EventArgs e)
        {
            UseSqlCommand(0);
            feedback.UpdateJhGoodsForm();
        }
        //修改按钮
        private void updateButton_Click(object sender, EventArgs e)
        {
            UseSqlCommand(1);
            feedback.UpdateJhGoodsForm();
        }
        //删除按钮
        private void deleteButton_Click(object sender, EventArgs e)
        {
            UseSqlCommand(2);
            feedback.UpdateJhGoodsForm();
        }

        //查询按钮
        private void queryButton_Click(object sender, EventArgs e)
        {
            
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
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataReader;
                this.dataGridView1.DataSource = bindingSource;
                
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("无查询结果");
                    
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

        private void JhGoodsForm_Load(object sender, EventArgs e)
        {

        }


        //DataGridView 选中一行而更新界面显示
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvr = dataGridView1.CurrentRow;

            txtGoodsID.Text = dgvr.Cells[0].Value.ToString();
            txtEmpID.Text = dgvr.Cells[1].Value.ToString();
            txtJhCompName.Text = dgvr.Cells[2].Value.ToString();
            txtDepotName.Text = dgvr.Cells[3].Value.ToString();
            txtGoodsName.Text = dgvr.Cells[4].Value.ToString();
            txtGoodsNum.Text = dgvr.Cells[5].Value.ToString();
            txtGoodsUnit.Text = dgvr.Cells[6].Value.ToString();
            txtGoodsJhPrice.Text = dgvr.Cells[7].Value.ToString();
            txtGoodsSellPrice.Text = dgvr.Cells[8].Value.ToString();
            txtGoodsNoPrice.Text = dgvr.Cells[10].Value.ToString();
            txtGoodsRemark.Text = dgvr.Cells[11].Value.ToString();

        }

        //
        public void FeedbackUseUpdate()
        {
            UpdateDataGridView();
        }

        
    }
}
