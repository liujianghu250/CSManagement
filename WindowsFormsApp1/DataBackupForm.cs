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
using WindowsFormsApp1.GoodMethod;


namespace WindowsFormsApp1
{
    public partial class DataBackupForm : Form
    {
        public DataBackupForm()
        {
            InitializeComponent();
        }

        private void fileChooseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathBox.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePathBox.Text != "" && fileNameBox.Text != "")
                {
                    SqlConnection con = new GetSqlConnection().GetCon();//连接数据库
                    string strBacl = "backup database db_CSManage to disk='" + filePathBox.Text.Trim() + "\\" + fileNameBox.Text.Trim() + ".bak'";
                    SqlCommand cmd = new SqlCommand(strBacl, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("数据备份成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("数据备份失败！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("请填写备份的正确位置及文件名！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
