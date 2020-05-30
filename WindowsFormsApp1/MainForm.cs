using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string curUser; //当前登录的用户

        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            //if(curUser == "root")
            {
                EmployeeInfoForm frm = new EmployeeInfoForm();
                frm.Owner = this;
                frm.ShowDialog();
            }
            //else
            {
            //    MessageBox.Show("当前登录账号没有访问该功能的权限");
            }
        }

        private void companyMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfoForm frm = new CompanyInfoForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void goodsPurchaseMenuItem_Click(object sender, EventArgs e)
        {
            JhGoodsForm jhGoodsForm = new JhGoodsForm("YH");
            jhGoodsForm.Owner = this;
            jhGoodsForm.ShowDialog();
        }

        private void GoodsInfoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SellGoodsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReturnGoodsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsFind frm = new GoodsFind();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsWarning frm = new GoodsWarning();
            frm.Owner = this;
            frm.ShowDialog();
        }



        private void DataBackupMenuItem_Click(object sender, EventArgs e)
        {
            DataBackupForm frm = new DataBackupForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void DataRecoveryMenuItem_Click(object sender, EventArgs e)
        {
            //if(curUser == "root")
            {
                DataRestore frm = new DataRestore();
                frm.Owner = this;
                frm.ShowDialog();
            }
            //else
            {
            //    MessageBox.Show("当前登录账号没有访问该功能的权限");
            }
        }
    }
}
