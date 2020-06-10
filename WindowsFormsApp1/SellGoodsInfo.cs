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
    public partial class SellGoodsInfo : Form
    {
        public SellGoodsInfo()
        {
            InitializeComponent();
        }
        private tb_ThGoodsMenthod thGoodsMenthod = new tb_ThGoodsMenthod();
        private void SellGoodsInfo_Load(object sender, EventArgs e) //用销售表生成treeview控件
        {
            thGoodsMenthod.filltProd(treeView1, imageList1);
        }
        //在treeview中选择要添加的退货商品信息然后点击确定按钮
        //添加商品信息按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Text != "商品销售信息")
            {
                if(treeView1.SelectedNode.Parent.Text == "商品销售信息")
                {
                    ThGoodsInfoForm thGoodsInfoForm = (ThGoodsInfoForm)this.Owner;
                    tb_SellGoodsMenthod sellGoodsMenthod = new tb_SellGoodsMenthod();
                    SqlConnection conn = (new GetSqlConnection()).GetCon();
                    string sqlcmd = "select * from tb_SellGoods where SellID='" + treeView1.SelectedNode.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    if(dataReader.HasRows)
                    {
                        thGoodsInfoForm.txtSellID.Text = dataReader[0].ToString();  //销售编号
                        thGoodsInfoForm.txtThGoodsName.Text = dataReader[3].ToString(); //商品名称
                        thGoodsInfoForm.goodsID = dataReader[1].ToString(); //商品编号
                        MessageBox.Show(thGoodsInfoForm.goodsID);
                        thGoodsInfoForm.txtPrice.Text = dataReader[6].ToString(); //退货单价
                        thGoodsInfoForm.num = dataReader[4].ToString(); //销售数量(限制输入的退货数量)
                        MessageBox.Show("最大退货数量为:" + thGoodsInfoForm.num);
                    }
                    dataReader.Close();
                    conn.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("选择商品销售编号");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
