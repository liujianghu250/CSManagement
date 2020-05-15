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
using WindowsFormsApp1.ClassInfo;
using WindowsFormsApp1.GoodMethod;

namespace WindowsFormsApp1
{
    public partial class CompanyInfoForm : Form
    {
        //成员变量
        private enum FlagType
        {
            Begin, Add
        }
        private FlagType flag;//标记
        private tb_Company company = new tb_Company();
        private tb_CompanyMethod comMethod = new tb_CompanyMethod();
        //构造函数
        public CompanyInfoForm()
        {
            InitializeComponent();
        }

        //方法
        private void ControlStatus()
        {
            saveButton.Enabled = !saveButton.Enabled;
            addButton.Enabled = !addButton.Enabled;
        }
        private void ClearControls()
        {
            companyNameBox.Text = "";
            companyPhoneBox.Text = "";
            companyDirectorBox.Text = "";
        }
        private Boolean CheckData()
        {
            switch (flag)
            {
                case FlagType.Add:
                    if (companyNameBox.Text == "")
                    {
                        MessageBox.Show("供应商名称不能为空！", "提示");
                        return false;
                    }
                    if (companyPhoneBox.Text == "")
                    {
                        MessageBox.Show("联系电话不能为空！", "提示");
                        return false;
                    }
                    if (companyDirectorBox.Text == "")
                    {
                        MessageBox.Show("负责人不能为空！", "提示");
                        return false;
                    }
                    company.intCompanyID = comMethod.tb_CompanyID();
                    company.intEmpFalg = 0;
                    company.strCompanyAddress = companyAddrBox.Text;
                    company.strCompanyDirector = companyDirectorBox.Text;
                    company.strCompanyFax = companyFaxBox.Text;
                    company.strCompanyName = companyNameBox.Text;
                    company.strCompanyPhone = companyPhoneBox.Text;
                    company.strCompanyRemark = companyRemarkBox.Text;
                    company.daReDateTime = DateTime.Now;
                    break;
            }
            return true;
        }

        //各种click函数
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(CheckData() == true)
            {
                switch (flag)
                {
                    case FlagType.Add:
                        if (comMethod.Add(company))
                        {
                            MessageBox.Show("添加成功");
                        }
                        else
                        {
                            MessageBox.Show("添加失败");
                        }
                        flag = FlagType.Begin;
                        comMethod.Find(dataGridView1);
                        //ClearControls();
                        ControlStatus();
                        break;
                    default:
                        break;
                }
            }



        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            flag = FlagType.Add;
        }
    }
}
