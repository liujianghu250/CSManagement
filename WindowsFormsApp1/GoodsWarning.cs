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
    public partial class GoodsWarning : Form
    {
        public GoodsWarning()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择商品信息");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("请输入商品警报数量");
                return;
            }
            //数据库操作
            //成功或失败

            //这里应该是向数据库写入，然后再查询一次在下面

            string sql;
            string conStr = "server=LAPTOP-J76DI15U;database=database1;uid=sa;pwd=123456;";//指定哪台服务器
                                                                                           //2.连接通道对象
            SqlConnection conn = new SqlConnection(conStr);

            //这里就是把数据写入数据库了

            //注意这里仓库可能需要查询，库存数量应该是在原有基础上的查询，加上此次的入库数量,警报数量同理

            sql= "insert into tb_warn(商品编号,商品名称,仓库名称,库存数量,警报数量) values('" + textBox1.Text+"', '"+textBox4.Text+   
                "', '上海仓库', "+ textBox3.Text + " ,"+ textBox6.Text + "  )";



            conn.Open();
            SqlCommand cmd= new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();


            conn.Close();


            conn.Open();


            //查询部分，将设置的警报显示
            sql = "select * from tb_warn where 商品编号=" + textBox1.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
