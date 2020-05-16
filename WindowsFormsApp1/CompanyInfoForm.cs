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
            Begin, Add, Delete,Update
        }
        private FlagType flag;//标记
        private tb_Company company = new tb_Company();
        private tb_CompanyMethod comMethod = new tb_CompanyMethod();
        //构造函数
        public CompanyInfoForm()
        {
            InitializeComponent();
            comMethod.Find(dataGridView1);
        }

        //方法
        private void ControlStatus()
        {
            saveButton.Enabled = !saveButton.Enabled;
            cancelButton.Enabled = !cancelButton.Enabled;
            addButton.Enabled = !addButton.Enabled;
            deleteButton.Enabled = !deleteButton.Enabled;
            updateButton.Enabled = !updateButton.Enabled;
        }
        private void BoxStatus()
        {
            companyNameBox.ReadOnly = !companyNameBox.ReadOnly;
            companyDirectorBox.ReadOnly = !companyDirectorBox.ReadOnly;
            companyPhoneBox.ReadOnly = !companyPhoneBox.ReadOnly;
            companyAddrBox.ReadOnly = !companyAddrBox.ReadOnly;
            companyFaxBox.ReadOnly = !companyFaxBox.ReadOnly;
            companyRemarkBox.ReadOnly = !companyRemarkBox.ReadOnly;
        }
        private void ClearControls()
        {
            companyNameBox.Text = "";
            companyPhoneBox.Text = "";
            companyDirectorBox.Text = "";
            companyAddrBox.Text = "";
            companyFaxBox.Text = "";
            companyRemarkBox.Text = "";
        }
        private void FillControls()
        {
            int curRow = dataGridView1.CurrentCell.RowIndex;

            companyNameBox.Text = dataGridView1[1, curRow].Value.ToString();
            companyDirectorBox.Text = dataGridView1[2, curRow].Value.ToString(); 
            companyPhoneBox.Text = dataGridView1[3, curRow].Value.ToString(); 
            companyAddrBox.Text = dataGridView1[4, curRow].Value.ToString(); 
            companyFaxBox.Text = dataGridView1[5, curRow].Value.ToString(); 
            companyRemarkBox.Text = dataGridView1[6, curRow].Value.ToString(); 
        }

        private Boolean CheckData()
        {
            if (flag == FlagType.Add || flag == FlagType.Update)
            {
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
                company.intEmpFlag = 0;
                company.strCompanyAddress = companyAddrBox.Text;
                company.strCompanyDirector = companyDirectorBox.Text;
                company.strCompanyFax = companyFaxBox.Text;
                company.strCompanyName = companyNameBox.Text;
                company.strCompanyPhone = companyPhoneBox.Text;
                company.strCompanyRemark = companyRemarkBox.Text;
                company.daReDateTime = DateTime.Now;
                if (flag == FlagType.Add)
                {
                    company.intCompanyID = comMethod.tb_CompanyID();
                }
            }
            else if(flag == FlagType.Delete)
            {
                if (companyNameBox.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！请选择要删除的的记录", "提示");
                    return false;
                }
                company.intEmpFlag = 1;
                company.intCompanyID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
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
                        ClearControls();
                        ControlStatus();
                        BoxStatus();
                        break;

                    case FlagType.Delete:
                        if (comMethod.Delete(company))
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                        flag = FlagType.Begin;
                        comMethod.Find(dataGridView1);
                        ClearControls();
                        ControlStatus();
                        break;

                    case FlagType.Update:
                        if (comMethod.Update(company))
                        {
                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                        }
                        flag = FlagType.Begin;
                        comMethod.Find(dataGridView1);
                        ClearControls();
                        BoxStatus();
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
            BoxStatus();
            ClearControls();
            flag = FlagType.Add;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            flag = FlagType.Delete;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ControlStatus();
            BoxStatus();
            flag = FlagType.Update;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyType;
            switch (keyTypeBox.Text)
            {
                case "供应商名称":
                    keyType = "ComName";
                    break;
                case "负责人姓名":
                    keyType = "ComDirector";
                    break;
                case "编号":
                    keyType = "ComID";
                    break;
                default:
                    MessageBox.Show("请选择查询条件！");
                    return;
            }

            string key = keyWordBox.Text;
            comMethod.Find(dataGridView1, key, keyType);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(flag == FlagType.Delete || flag == FlagType.Begin)
            {
                FillControls();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            if(flag == FlagType.Add || flag == FlagType.Update)
            {
                BoxStatus();
            }
            flag = FlagType.Begin;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
