using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ClassInfo;
using WindowsFormsApp1.GoodMethod;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class EmployeeInfoForm : Form
    {
        //成员变量
        private enum FlagType
        {
            Begin, Add, Delete, Update
        }
        private FlagType flag;//标记
        private tb_Employee employee = new tb_Employee();
        private tb_EmployeeMethod empMethod = new tb_EmployeeMethod();

        public EmployeeInfoForm()
        {
            InitializeComponent();
            empMethod.Find(dataGridView1);
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
            empNameBox.ReadOnly = !empNameBox.ReadOnly;
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
            loginNameBox.ReadOnly = !loginNameBox.ReadOnly;
            empAddrBox.ReadOnly = !empAddrBox.ReadOnly;
            loginPwdBox.ReadOnly = !loginPwdBox.ReadOnly;
            phoneBox.ReadOnly = !phoneBox.ReadOnly;
            mobilePhoneBox.ReadOnly = !mobilePhoneBox.ReadOnly;
        }
        private void ClearControls()
        {
            empNameBox.Text = "";
            loginNameBox.Text = "";
            empAddrBox.Text = "";
            loginPwdBox.Text = "";
            phoneBox.Text = "";
            mobilePhoneBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void FillControls()
        {
            int curRow = dataGridView1.CurrentCell.RowIndex;
            empNameBox.Text = dataGridView1[1, curRow].Value.ToString();
            loginNameBox.Text = dataGridView1[2, curRow].Value.ToString();
            loginPwdBox.Text = dataGridView1[3, curRow].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[5, curRow].Value.ToString());
            phoneBox.Text = dataGridView1[8, curRow].Value.ToString();
            mobilePhoneBox.Text = dataGridView1[9, curRow].Value.ToString();
            empAddrBox.Text = dataGridView1[10, curRow].Value.ToString();
        }

        private Boolean CheckData()
        {
            if (flag == FlagType.Add || flag == FlagType.Update)
            {
                if (empNameBox.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！", "提示");
                    return false;
                }
                if (phoneBox.Text == "")
                {
                    MessageBox.Show("联系电话不能为空！", "提示");
                    return false;
                }
                employee.strEmpAddress = empAddrBox.Text;
                employee.strEmpName = empNameBox.Text;
                employee.strEmpPhone = phoneBox.Text;
                employee.strEmpLoginName = loginNameBox.Text;
                employee.strEmpLoginPwd = loginPwdBox.Text;
                employee.strEmpPhoneM = mobilePhoneBox.Text;
                employee.daEmpBirthday = dateTimePicker1.Value;
                if (flag == FlagType.Add)
                {
                    employee.intEmpID = empMethod.tb_employeeID();
                }
                else
                {
                    employee.intEmpID = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
            }
            else if (flag == FlagType.Delete)
            {
                if (empNameBox.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！请选择要删除的的记录", "提示");
                    return false;
                }
                employee.intEmpFlag = 1;
                employee.intEmpID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
            }
            return true;
        }

        //各种click函数


        private void addButton_Click(object sender, EventArgs e)
        {
            ControlStatus();
            BoxStatus();
            ClearControls();
            flag = FlagType.Add;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            if (flag == FlagType.Add || flag == FlagType.Update)
            {
                BoxStatus();
            }
            flag = FlagType.Begin;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == FlagType.Delete || flag == FlagType.Begin)
            {
                FillControls();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyType;
            switch (keyTypeBox.Text)
            {
                case "供应商名称":
                    keyType = "empName";
                    break;
                case "负责人姓名":
                    keyType = "empDirector";
                    break;
                case "编号":
                    keyType = "empID";
                    break;
                default:
                    MessageBox.Show("请选择查询条件！");
                    return;
            }

            string key = keyWordBox.Text;
            empMethod.Find(dataGridView1, key, keyType);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ControlStatus();
            BoxStatus();
            flag = FlagType.Update;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //ClearControls();
            ControlStatus();
            flag = FlagType.Delete;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                switch (flag)
                {
                    case FlagType.Add:
                        if (empMethod.Add(employee))
                        {
                            MessageBox.Show("添加成功");
                        }
                        else
                        {
                            MessageBox.Show("添加失败");
                        }
                        flag = FlagType.Begin;
                        empMethod.Find(dataGridView1);
                        ClearControls();
                        ControlStatus();
                        BoxStatus();
                        break;

                    case FlagType.Delete:
                        if (empMethod.Delete(employee))
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                        flag = FlagType.Begin;
                        empMethod.Find(dataGridView1);
                        ClearControls();
                        ControlStatus();
                        break;

                    case FlagType.Update:
                        if (empMethod.Update(employee))
                        {
                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                        }
                        flag = FlagType.Begin;
                        empMethod.Find(dataGridView1);
                        ClearControls();
                        BoxStatus();
                        ControlStatus();
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
