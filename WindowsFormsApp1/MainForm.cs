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


        private void companyMenu_Click(object sender, EventArgs e)
        {
            CompanyInfoForm frm = new CompanyInfoForm();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
