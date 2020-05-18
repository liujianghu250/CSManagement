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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            //开发测试阶段无需对用户名与密码进行验证。
            /////////////////////////////////////////
            /* 
             *
            if(userName.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if(password.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
           
            if(new tb_EmployeeMethod().Find(userName.Text,password.Text) == true)
             */
            {
                JhGoodsForm jhGoodsForm = new JhGoodsForm("YH");
                jhGoodsForm.Show();
                /*CompanyInfoForm companyInfoForm = new CompanyInfoForm();
                companyInfoForm.Show();*/
                /*MainForm frm = new MainForm();
                frm.Show();
                this.Hide();*/
            }
          

        }
    }
}
