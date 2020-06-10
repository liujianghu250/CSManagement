using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ClassInfo;
using WindowsFormsApp1.GoodMethod;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ThGoodsInfoForm : Form
    {
        public ThGoodsInfoForm()
        {
            InitializeComponent();
        }
        public ThGoodsInfoForm(string EmpID) : this()
        {
            txtEmpID.Text = EmpID;
            thGoodsInfo = new tb_ThGoodsInfo();
            thGoodsMenthod = new tb_ThGoodsMenthod();
            thGoodsMenthod.Find(dataGridView1);
        }
        private tb_ThGoodsInfo thGoodsInfo;
        private tb_ThGoodsMenthod thGoodsMenthod;
        public int count = 0;           //用来判断工具栏中那个按钮被选中,1是添加，2是修改，3是删除
        public string goodsID = null;   //商品编号
        public string num = null;       //销售数量
        private void ChangeToolsStatus()    //改变工具栏按钮状态
        {
            this.saveButton.Enabled = !this.saveButton.Enabled;
            this.cancelButton.Enabled = !this.cancelButton.Enabled;
            this.addButton.Enabled = !this.addButton.Enabled;
            this.deleteButton.Enabled = !this.deleteButton.Enabled;
            this.updateButton.Enabled = !this.updateButton.Enabled;
        }
        public void Clear() //清空文本栏
        {
            txtThGoodsID.Text = "";
            txtSellID.Text = "";
            txtThGoodsName.Text = "";
            txtPrice.Text = "";
            txtThGoodsNum.Text = "";
            txtThNeedPay.Text = "";
            txtThHasPay.Text = "";
            txtThGoodsResult.Text = "";
        }
        public void Ban()   //禁止输入
        {
            daThGoodsTime.Enabled = false;
            txtThGoodsNum.Enabled = false;
            txtThHasPay.Enabled = false;
            txtThGoodsResult.Enabled = false;
        }
        public void Allow() //允许输入
        {
            daThGoodsTime.Enabled = true;
            txtThGoodsNum.Enabled = true;
            txtThHasPay.Enabled = true;
            txtThGoodsResult.Enabled = true;
        }
        public bool IsComplete()
        {
            bool flag = false;
            if (count == 1 || count == 2)    //添加或修改
            {
                if (txtThGoodsID.Text == "")
                {
                    MessageBox.Show("退货编号为空,请重新输入");
                    return flag;
                }
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("销售编号为空，请重新输入");
                    return flag;
                }
                if (txtThGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称为空，请重新输入");
                    return flag;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("退货单价为空，请重新输入");
                    return flag;
                }
                if (txtThGoodsNum.Text == "")
                {
                    MessageBox.Show("退货数量为空，请重新输入");
                    return flag;
                }
                if (txtThHasPay.Text == "")
                {
                    MessageBox.Show("已退款金额为空，请重新输入");
                    return flag;
                }
                thGoodsInfo.strThGoodsID = txtThGoodsID.Text;        //退货编号
                thGoodsInfo.strGoodsID = goodsID;                    //商品编号
                thGoodsInfo.strSellID = txtSellID.Text;              //销售编号
                thGoodsInfo.intEmpId = txtEmpID.Text;                //员工编号
                thGoodsInfo.strThGoodsName = txtThGoodsName.Text;    //商品名称
                thGoodsInfo.intThGoodsNum = Convert.ToInt32(txtThGoodsNum.Text);    //退货数量
                thGoodsInfo.daThGoodsTime = daThGoodsTime.Value;     //退货时间
                thGoodsInfo.deThGoodsPrice = txtPrice.Text;          //退货单价
                thGoodsInfo.deThNeedPay = txtThNeedPay.Text;         //应付金额
                thGoodsInfo.deThHasPay = txtThHasPay.Text;           //已退款金额
                thGoodsInfo.deThGoodsResult = txtThGoodsResult.Text; //退款原因
            }
            if (count == 3)      //删除
            {
                if (txtThGoodsID.Text == "")
                {
                    MessageBox.Show("退货编号为空，请重新输入");
                    return flag;
                }
            }
            flag = true;   //输入消息完整，可以进行数据库操作
            return flag;
        }
        //保存按钮
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                if (count == 1)  //添加操作
                {
                    if (thGoodsMenthod.Add(thGoodsInfo))
                    {
                        if(num == txtThGoodsNum.Text)   //置对应的销售记录删除标志为1
                        {
                            string sqlcmd = "update tb_SellGoods set SellFlag=1 where SellID='" + txtSellID.Text + "'";
                            SqlConnection conn = (new GetSqlConnection()).GetCon();
                            SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                            cmd.ExecuteNonQuery();
                            conn.Dispose();
                        }
                        MessageBox.Show("添加成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        thGoodsMenthod.Find(dataGridView1);   //返回操作后的数据库
                        button1.Enabled = false;
                        Ban();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        button1.Enabled = false;
                        Ban();
                    }
                }
                if (count == 2)  //修改操作
                {
                    if (thGoodsMenthod.Update(thGoodsInfo, this.dataGridView1[3, this.dataGridView1.CurrentCell.RowIndex].Value.ToString()))
                    {
                        if (num == txtThGoodsNum.Text)   //置对应的销售记录删除标志为1
                        {
                            string sqlcmd = "update tb_SellGoods set SellFlag=1 where SellID='" + txtSellID.Text + "'";
                            SqlConnection conn = (new GetSqlConnection()).GetCon();
                            SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                            cmd.ExecuteNonQuery();
                            conn.Dispose();
                        }
                        MessageBox.Show("修改成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        thGoodsMenthod.Find(dataGridView1);   //返回操作后的数据库
                        Ban();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        Ban();
                    }
                }
                if (count == 3)  //删除操作
                {
                    if (thGoodsMenthod.Delete(thGoodsInfo.strThGoodsID))
                    {
                        MessageBox.Show("删除成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        thGoodsMenthod.Find(dataGridView1);   //返回操作后的数据库
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                    }
                }
            }
        }
        //取消按钮
        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("取消操作");
            Clear();
            ChangeToolsStatus();
            if (count == 1 || count == 2)
            {
                button1.Enabled = false;
                Ban();
            }
            count = 0;
        }
        //添加按钮
        private void addButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 1;  //添加操作
            txtThGoodsID.Text = thGoodsMenthod.tb_ThGoodsID();
            button1.Enabled = true;
            Allow();
        }
        //删除按钮
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 3;  //删除操作
        }
        //修改按钮
        private void updateButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 2;  //修改操作
            //Allow();    
        }
        //退出按钮
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (count == 1 || count == 2)
            {
                button1.Enabled = false;
                Ban();
            }
            this.Close();
        }
        //对输入做出限制
        //退货数量
        private void txtThGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }
        //已退款金额
        private void txtThHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }
        //自动计算应付金额
        private void txtThGoodsNum_TextChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(num);
            if (txtThGoodsNum.Text != "")
            {
                if (count == 1 || count == 2)
                {
                    if (Convert.ToInt32(txtThGoodsNum.Text) <= n)
                    {
                        txtThNeedPay.Text = Convert.ToString(Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtThGoodsNum.Text));  //自动计算应付金额 = 单价 * 数量
                    }
                    else
                    {
                        MessageBox.Show("输入销售数量有误,请重新输入");
                        txtThGoodsNum.Text = "";
                        txtThNeedPay.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellGoodsInfo sellGoodsInfo = new SellGoodsInfo();
            sellGoodsInfo.Owner = this;
            sellGoodsInfo.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (count == 2)    //对数据库中的某一记录做修改
            {
                try
                {
                    int n = 0;
                    SqlConnection conn = (new GetSqlConnection()).GetCon();
                    string sqlcmd = "select * from tb_ThGoodsInfo where ThGoodsID='" + this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString() + "'";
                    //MessageBox.Show(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    string sqlcmd1 = "select * from tb_SellGoods where SellID='";
                    if (dataReader.HasRows)
                    {
                        txtThGoodsID.Text = dataReader[0].ToString();   //退货编号
                        txtThGoodsID.Enabled = false;
                        sqlcmd1 += dataReader[2].ToString() + "'";
                        goodsID = dataReader[1].ToString();             //商品编号
                        txtSellID.Text = dataReader[2].ToString();      //销售编号
                        txtEmpID.Text = dataReader[3].ToString();       //员工编号
                        txtThGoodsName.Text = dataReader[4].ToString();   //商品名称
                        daThGoodsTime.Value = Convert.ToDateTime(dataReader[6].ToString());//退货时间
                        txtPrice.Text = dataReader[7].ToString();       //退货单价
                        txtThNeedPay.Text = dataReader[8].ToString();   //应付金额
                        txtThHasPay.Text = dataReader[9].ToString();    //实付金额
                        txtThGoodsResult.Text = dataReader[10].ToString(); //退货原因
                    }
                    dataReader.Close();
                    //通过销售编号查询销售数量
                    SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                    SqlCommand cmd1 = new SqlCommand(sqlcmd1, conn);
                    SqlDataReader dataReader1 = cmd1.ExecuteReader();
                    dataReader1.Read();
                    n += Convert.ToInt32(dataReader1[4]);    //退货数量最大值为销售数量
                    dataReader1.Close();
                    num = n.ToString();
                    Allow();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
            if (count == 3)  //对数据库中的某一记录做删除
            {
                try
                {
                    SqlConnection conn = (new GetSqlConnection()).GetCon();
                    string sqlcmd = "select * from tb_ThGoodsInfo where ThGoodsID='" + this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString() + "'";
                    //MessageBox.Show(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    if (dataReader.HasRows)
                    {
                        txtThGoodsID.Text = dataReader[0].ToString();   //退货编号
                        txtThGoodsID.Enabled = false;
                        txtSellID.Text = dataReader[2].ToString();      //销售编号
                        txtEmpID.Text = dataReader[3].ToString();       //员工编号
                        txtThGoodsName.Text = dataReader[4].ToString();   //商品名称
                        txtThGoodsNum.Text = dataReader[5].ToString();      //退货数量
                        daThGoodsTime.Value = Convert.ToDateTime(dataReader[6].ToString());//退货时间
                        txtPrice.Text = dataReader[7].ToString();       //退货单价
                        txtThNeedPay.Text = dataReader[8].ToString();   //应付金额
                        txtThHasPay.Text = dataReader[9].ToString();    //实付金额
                        txtThGoodsResult.Text = dataReader[10].ToString(); //退货原因
                    }
                    dataReader.Close();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }
            }
        }
    }
}
