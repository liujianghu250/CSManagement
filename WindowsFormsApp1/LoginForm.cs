using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Method;
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
            /*
            SqlConnection Conn = (new getSqlConnection()).GetCon();
            SqlCommand cmd = new SqlCommand("sp_help tb_Company", Conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
               textBox1.Text += dataReader[0].ToString();
            }
            dataReader.Close();
            Conn.Close();
            */
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }
    }
}
