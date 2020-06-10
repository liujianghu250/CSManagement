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
using WindowsFormsApp1.ClassInfo;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class GoodIDForm : Form
    {
        public GoodIDForm()
        {
            InitializeComponent();
        }
        private tb_SellGoodsMenthod sellGoodsMenthod = new tb_SellGoodsMenthod();
        private void GoodIDForm_Load(object sender, EventArgs e)
        {
            sellGoodsMenthod.filltProd(treeView1, imageList1);
        }
        //在treeview控件中选择要添加的商品信息然后点击确定按钮
        //添加商品信息按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "商品名称")
            {
                if (treeView1.SelectedNode.Parent.Text != "商品名称")
                {
                    SellGoodsForm sellGoodsForm = (SellGoodsForm)this.Owner;
                    string strName = treeView1.SelectedNode.Text;
                    sellGoodsForm.txtGoodsName.Text = strName;
                    //sellGoodsForm.kcID = sellGoodsMenthod.fillfrmKcGoods(treeView1.SelectedNode.Parent.Text);
                    //sellGoodsForm.kcID = "KC-" + treeView1.SelectedNode.Parent.Text.ToString();
                    sellGoodsForm.goodsID = treeView1.SelectedNode.Parent.Text.ToString();
                    string sqlcmd1 = "select * from tb_KcGoods where GoodsID='"; //用商品编号从库存表中查找当前库存数量
                    sqlcmd1 += treeView1.SelectedNode.Parent.Text.ToString();
                    sqlcmd1 += "'";
                    SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                    SqlCommand cmd1 = new SqlCommand(sqlcmd1, conn1);
                    SqlDataReader dataReader1 = cmd1.ExecuteReader();
                    dataReader1.Read();
                    sellGoodsForm.kcNum = dataReader1[3].ToString();
                    dataReader1.Close();
                    conn1.Dispose();
                    MessageBox.Show("该商品当前库存数量为" + sellGoodsForm.kcNum);
                    string sqlcmd2 = "select * from tb_JhGoodsInfo where GoodsID='" + treeView1.SelectedNode.Parent.Text.ToString() + "'";
                    SqlConnection conn2 = (new GetSqlConnection()).GetCon();
                    SqlCommand cmd2 = new SqlCommand(sqlcmd2, conn2);
                    SqlDataReader dataReader2 = cmd2.ExecuteReader();
                    dataReader2.Read();
                    sellGoodsForm.txtdeSellPrice.Text = dataReader2[8].ToString();//销售单价
                    dataReader2.Close();
                    conn2.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("选择商品名称");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
