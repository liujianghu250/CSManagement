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
    public partial class SellGoodsForm : Form
    {
        public SellGoodsForm()
        {
            InitializeComponent();
        }
        public SellGoodsForm(string EmpID) : this()
        {
            txtEmpID.Text = EmpID;
            sellGoods = new tb_SellGoods();
            sellGoodsMenthod = new tb_SellGoodsMenthod();
            sellGoodsMenthod.Find(dataGridView1);
        }
        private tb_SellGoods sellGoods;
        private tb_SellGoodsMenthod sellGoodsMenthod;
        public int count = 0;   //用来判断工具栏中那个按钮被选中,1是添加，2是修改，3是删除
        public string goodsID = null;   //商品编号
        //public string kcID = "";    //用商品编号在库存表中查询到的库存编号
        public string kcNum;    //用商品编号在库存表中查询到的库存数量，用来限制销售数量的输入
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
            txtSellID.Text = "";
            txtGoodsName.Text = "";
            txtdeSellPrice.Text = "";
            txtSellGoodsNum.Text = "";
            //txtEmpID.Text = "";
            txtdeSellNeedPay.Text = "";
            txtdeSellHasPay.Text = "";
            txtSellRemark.Text = "";
        }
        public void Ban()  //禁止输入
        {
            //txtGoodsName.Enabled = false;
            //button1.Enabled = false;
            DaSellGoodsTime.Enabled = false;
            txtSellGoodsNum.Enabled = false;
            //txtEmpID.Enabled = false;
            txtdeSellHasPay.Enabled = false;
            txtSellRemark.Enabled = false;
        }
        public void Allow() //允许输入
        {
            //txtGoodsName.Enabled = true;
            //button1.Enabled = true;
            DaSellGoodsTime.Enabled = true;
            txtSellGoodsNum.Enabled = true;
            //txtEmpID.Enabled = true;
            txtdeSellHasPay.Enabled = true;
            txtSellRemark.Enabled = true;
        }
        public bool IsComplete()
        {
            bool flag = false;
            if (count == 1 || count == 2)    //添加或修改
            {
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("商品销售编号为空,请重新输入");
                    return flag;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称为空，请重新输入");
                    return flag;
                }
                if (txtdeSellPrice.Text == "")
                {
                    MessageBox.Show("商品单价为空，请重新输入");
                    return flag;
                }
                if (txtSellGoodsNum.Text == "")
                {
                    MessageBox.Show("商品数量为空，请重新输入");
                    return flag;
                }
                if (txtdeSellHasPay.Text == "")
                {
                    MessageBox.Show("实付金额为空，请重新输入");
                    return flag;
                }
                //kcID = sellGoodsMenthod.fillfrmKcGoods(txtGoodsID.Text);
                sellGoods.strSellID = txtSellID.Text;   //商品销售编号
                sellGoods.strGoodsName = txtGoodsName.Text; //商品名称
                sellGoods.daSellGoodsTime = DaSellGoodsTime.Value;  //销售时间
                //sellGoods.strKcID = kcID;    //库存编号
                //sellGoods.strGoodsID = txtGoodsID.Text;         
                sellGoods.strGoodsID = goodsID;     //商品编号
                sellGoods.deSellPrice = txtdeSellPrice.Text; //商品单价
                sellGoods.strSellGoodsNum = Convert.ToInt32(txtSellGoodsNum.Text);  //销售数量
                sellGoods.strEmpId = txtEmpID.Text;     //员工编号
                sellGoods.deSellNeedPay = txtdeSellNeedPay.Text;    //应付金额
                sellGoods.deSellHasPay = txtdeSellHasPay.Text;      //实付金额
                sellGoods.strSellRemark = txtSellRemark.Text;       //备注
                sellGoods.intSellFlag = 0;  //置未删除标记
            }
            if (count == 3)      //删除
            {
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("商品销售编号为空，请重新输入");
                    return flag;
                }
                sellGoods.strSellID = txtSellID.Text;   //商品销售编号
                sellGoods.intSellFlag = 1;  //置已删除标志
            }
            flag = true;   //输入消息完整，可以进行数据库操作
            return flag;
        }
        private void exitButton_Load(object sender, EventArgs e)
        {

        }
        //添加按钮
        private void addButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 1;  //添加操作
            txtSellID.Text = sellGoodsMenthod.tb_SellID();
            //txtSellID.Enabled = false;
            button1.Enabled = true;
            Allow();
        }
        //删除按钮
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 3;
        }
        //修改按钮
        private void updateButton_Click(object sender, EventArgs e)
        {
            ChangeToolsStatus();
            count = 2;
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
        //保存按钮
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(IsComplete())
            {
                if(count == 1)  //添加操作
                {
                    if(sellGoodsMenthod.Add(sellGoods))
                    {
                        MessageBox.Show("添加成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        sellGoodsMenthod.Find(dataGridView1);   //返回操作后的数据库
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
                if(count == 2)  //修改操作
                {
                    if(sellGoodsMenthod.Update(sellGoods,this.dataGridView1[3,this.dataGridView1.CurrentCell.RowIndex].Value.ToString()))
                    {
                        MessageBox.Show("修改成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        sellGoodsMenthod.Find(dataGridView1);
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
                if(count == 3)  //删除操作
                {
                    if(sellGoodsMenthod.Delete(sellGoods))
                    {
                        MessageBox.Show("删除成功");
                        Clear();
                        ChangeToolsStatus();
                        count = 0;
                        sellGoodsMenthod.Find(dataGridView1);
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
            if(count == 1 || count == 2)
            {
                button1.Enabled = false;
                Ban();
            }
            count = 0;
        }
        //对输入做出限制
        //销售数量
        private void txtSellGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }
        //实付金额
        private void txtdeSellHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }
        //自动计算应付金额
        private void txtSellGoodsNum_TextChanged(object sender, EventArgs e)
        {
            int kcnum = Convert.ToInt32(kcNum);
            if(txtSellGoodsNum.Text != "")
            {
                if(count == 1 || count == 2)
                {
                    if (Convert.ToInt32(txtSellGoodsNum.Text) <= kcnum)
                    {
                        txtdeSellNeedPay.Text = Convert.ToString(Convert.ToDouble(txtdeSellPrice.Text) * Convert.ToInt32(txtSellGoodsNum.Text));  //自动计算应付金额 = 单价 * 数量
                    }
                    else
                    {
                        MessageBox.Show("输入销售数量有误,请重新输入");
                        txtSellGoodsNum.Text = "";
                        txtdeSellNeedPay.Text = "";
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(count == 2)    //对数据库中的某一记录做修改
            {
                try
                {
                    int n = 0;
                    SqlConnection conn = (new GetSqlConnection()).GetCon();
                    string sqlcmd = "select * from tb_SellGoods where SellID='" + this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString() + "'";
                    //MessageBox.Show(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    string sqlcmd1 = "select * from tb_KcGoods where GoodsID='";
                    if (dataReader.HasRows)
                    {
                        txtSellID.Text = dataReader[0].ToString();      //商品销售编号
                        txtSellID.Enabled = false;
                        sqlcmd1 += dataReader[1].ToString() + "'";      //商品编号
                        txtEmpID.Text = dataReader[2].ToString();       //员工编号
                        txtGoodsName.Text = dataReader[3].ToString();   //商品名称
                        n = Convert.ToInt32(dataReader[4].ToString());
                        //txtSellGoodsNum.Text = dataReader[4].ToString();//销售数量
                        DaSellGoodsTime.Value = Convert.ToDateTime(dataReader[5].ToString());//销售时间
                        txtdeSellPrice.Text = dataReader[6].ToString(); //商品单价
                        txtdeSellNeedPay.Text = dataReader[7].ToString();   //应付金额
                        txtdeSellHasPay.Text = dataReader[8].ToString();    //实付金额
                        txtSellRemark.Text = dataReader[9].ToString(); //备注
                    }
                    dataReader.Close();
                    //查询当前库存数量改变kcNum的值
                    SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                    SqlCommand cmd1 = new SqlCommand(sqlcmd1, conn);
                    SqlDataReader dataReader1 = cmd1.ExecuteReader();
                    dataReader1.Read();
                    n += Convert.ToInt32(dataReader1[3].ToString());    //销售数量最大值等于当前库存加上修改之前的销售数量
                    dataReader1.Close();
                    kcNum = n.ToString();
                    Allow();
                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
            if(count == 3)  //对数据库中的某一记录做删除
            {
                try
                {
                    SqlConnection conn = (new GetSqlConnection()).GetCon();
                    string sqlcmd = "select * from tb_SellGoods where SellID='" + this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString() + "'";
                    //MessageBox.Show(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    if (dataReader.HasRows)
                    {
                        txtSellID.Text = dataReader[0].ToString();      //商品销售编号
                        txtSellID.Enabled = false;
                        txtEmpID.Text = dataReader[2].ToString();       //员工编号
                        txtGoodsName.Text = dataReader[3].ToString();   //商品名称
                        txtSellGoodsNum.Text = dataReader[4].ToString();//销售数量
                        DaSellGoodsTime.Value = Convert.ToDateTime(dataReader[5].ToString());//销售时间
                        txtdeSellPrice.Text = dataReader[6].ToString(); //商品单价
                        txtdeSellNeedPay.Text = dataReader[7].ToString();   //应付金额
                        txtdeSellHasPay.Text = dataReader[8].ToString();    //实付金额
                        txtSellRemark.Text = dataReader[9].ToString(); //备注
                    }
                    dataReader.Close();
                }
                catch(Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }
            }
        }
        //选择商品名称
        private void button1_Click(object sender, EventArgs e)
        {
            GoodIDForm goodIDForm = new GoodIDForm();
            goodIDForm.Owner = this;
            goodIDForm.ShowDialog();
        }
    }
}
