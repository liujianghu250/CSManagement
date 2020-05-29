using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("获取.txt", webBrowser1.Document.Body.InnerText + "\n" + "结束标志EOFFXXX");



            string line = string.Empty;

            int cnt = 0;

            bool flag = false;

            using (StreamReader reader = new StreamReader("获取.txt"))
            {
                while ((line = reader.ReadLine()) != "结束标志EOFFXXX")
                {

                    //MessageBox.Show(line + cnt.ToString());

                    int len = line.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (line[i] == '¥')
                        {
                            MessageBox.Show("下面是第一个找到的商品信息");
                            flag = true;
                        }
                    }
                    if (flag) cnt++;


                    if (cnt == 1)//读取到的是价钱
                    {
                        MessageBox.Show("价钱是    "+line);
                    }
                    else if (cnt == 3)//付款人数
                    {
                        MessageBox.Show("付款人数是     "+line);
                    }
                    else if (cnt == 6)//商品名称
                    {
                        MessageBox.Show("商品名称是    "+line);
                    }
                    else if (cnt == 9)//厂家名称
                    {
                        MessageBox.Show("厂家名称是      "+line);
                    }
                    else if (cnt == 11)//厂家地址
                    {
                        MessageBox.Show("厂家地址是     "+line);
                    }
                    else if (cnt == 12) break;

                }
            }



            System.IO.File.WriteAllText(@"获取.txt", string.Empty);//删除获取的内容
        }

        private void Query_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://s.taobao.com/search");
        }
    }
}
