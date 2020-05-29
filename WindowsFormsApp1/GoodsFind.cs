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

namespace WindowsFormsApp1
{
    public partial class GoodsFind : Form
    {
        public GoodsFind()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable dt = new DataTable();//我觉得需要把每一步的查询都保存下来
        SqlConnection conn;
        string sql;
        SqlDataAdapter sda;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入查询信息");
                return;
            }


            
            switch (comboBox1.Text)
            {
                case "商品编号"://"商品编号":
                    string conStr = "server=LAPTOP-J76DI15U;database=database1;uid=sa;pwd=123456;";//指定哪台服务器
                                                                                                  //2.连接通道对象
                    conn = new SqlConnection(conStr);
                    //3.打开通道
                    conn.Open();
                    /*
                     需要查询的表格名称为tb_Goods
                     */

                    sql = "select * from tb_Goods where 商品编号=" + textBox1.Text;
                    sda = new SqlDataAdapter(sql, conn);
                    
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    /*
                    string sql = "select * from tb_Goods where 商品编号="+textBox1.Text;


                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr;   //创建DataReader对象  
                    dr = cmd.ExecuteReader();    //执行查询  
                    if (dr.HasRows)  //判断数据库中是否含有数据
                    {
                        MessageBox.Show("含有数据并读取：");
                        while (dr.Read())
                        {
                            //Console.Write(dr[0].ToString() + ",");
                            //Console.Write(dr[1].ToString() + ",");
                            //Console.Write(dr[2].ToString() + ",");
                            //Console.Write(dr[3].ToString() + ",");
                            //Console.Write(dr[6].ToString() + ",");
                            //Console.Write(dr[7].ToString() + "," + "\n");
                            MessageBox.Show(dr[0].ToString() + dr[1].ToString()+ dr[2].ToString()+ dr[3].ToString()+
                                dr[4].ToString());

                            
                        }
                    }
                    else MessageBox.Show("不含有数据");
                    dr.Close();
                    conn.Close();
                    */
                    break;
                case "商品名称"://商品名称"
                    //数据库
                    conStr = "server=LAPTOP-J76DI15U;database=database1;uid=sa;pwd=123456;";//指定哪台服务器
                                                                                                   //2.连接通道对象
                    conn = new SqlConnection(conStr);
                    //3.打开通道
                    conn.Open();
                    /*
                     需要查询的表格名称为tb_Goods
                     */

                    MessageBox.Show("含有数据并读取：");


                    sql = "select * from tb_Goods where 商品名称=" +"'"+ textBox1.Text+"'";
                    sda = new SqlDataAdapter(sql, conn);

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query frm = new Query();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
