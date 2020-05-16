namespace WindowsFormsApp1
{
    partial class EmployeeInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfoForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.keyTypeBox = new System.Windows.Forms.ToolStripComboBox();
            this.keyWordBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginPwdBox = new System.Windows.Forms.TextBox();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.empAddrBox = new System.Windows.Forms.TextBox();
            this.empNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.cancelButton,
            this.deleteButton,
            this.addButton,
            this.updateButton,
            this.toolStripLabel1,
            this.keyTypeBox,
            this.keyWordBox,
            this.searchButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 25);
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 25);
            this.cancelButton.Text = "取消";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 25);
            this.deleteButton.Text = "删除";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 25);
            this.addButton.Text = "添加";
            this.addButton.ToolTipText = "添加";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 25);
            this.updateButton.Text = "修改";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 25);
            this.toolStripLabel1.Text = "查询条件：";
            // 
            // keyTypeBox
            // 
            this.keyTypeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "员工姓名",
            "员工性别",
            "所属部门",
            "员工职位"});
            this.keyTypeBox.Items.AddRange(new object[] {
            "编号",
            "供应商名称",
            "负责人姓名"});
            this.keyTypeBox.Name = "keyTypeBox";
            this.keyTypeBox.Size = new System.Drawing.Size(121, 28);
            // 
            // keyWordBox
            // 
            this.keyWordBox.Name = "keyWordBox";
            this.keyWordBox.Size = new System.Drawing.Size(100, 28);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 25);
            this.searchButton.Text = "查找";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 25);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.empName,
            this.loginName,
            this.loginPwd,
            this.sex,
            this.Column1,
            this.dept,
            this.post,
            this.家庭电话,
            this.phone,
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(49, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(705, 193);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loginPwdBox
            // 
            this.loginPwdBox.Location = new System.Drawing.Point(499, 72);
            this.loginPwdBox.Name = "loginPwdBox";
            this.loginPwdBox.ReadOnly = true;
            this.loginPwdBox.Size = new System.Drawing.Size(230, 25);
            this.loginPwdBox.TabIndex = 24;
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(149, 75);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.ReadOnly = true;
            this.loginNameBox.Size = new System.Drawing.Size(230, 25);
            this.loginNameBox.TabIndex = 22;
            // 
            // empAddrBox
            // 
            this.empAddrBox.Location = new System.Drawing.Point(149, 149);
            this.empAddrBox.Multiline = true;
            this.empAddrBox.Name = "empAddrBox";
            this.empAddrBox.ReadOnly = true;
            this.empAddrBox.Size = new System.Drawing.Size(583, 50);
            this.empAddrBox.TabIndex = 21;
            // 
            // empNameBox
            // 
            this.empNameBox.Location = new System.Drawing.Point(149, 33);
            this.empNameBox.Name = "empNameBox";
            this.empNameBox.ReadOnly = true;
            this.empNameBox.Size = new System.Drawing.Size(230, 25);
            this.empNameBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "家庭电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "出生日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "系统登录名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "员工姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "手机号码";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(149, 110);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.ReadOnly = true;
            this.phoneBox.Size = new System.Drawing.Size(230, 25);
            this.phoneBox.TabIndex = 28;
            // 
            // mobilePhoneBox
            // 
            this.mobilePhoneBox.Location = new System.Drawing.Point(499, 113);
            this.mobilePhoneBox.Name = "mobilePhoneBox";
            this.mobilePhoneBox.ReadOnly = true;
            this.mobilePhoneBox.Size = new System.Drawing.Size(230, 25);
            this.mobilePhoneBox.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 25);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // empID
            // 
            this.empID.HeaderText = "员工编号";
            this.empID.Name = "empID";
            // 
            // empName
            // 
            this.empName.HeaderText = "员工姓名";
            this.empName.Name = "empName";
            // 
            // loginName
            // 
            this.loginName.HeaderText = "登录用户名";
            this.loginName.Name = "loginName";
            this.loginName.Visible = false;
            // 
            // loginPwd
            // 
            this.loginPwd.HeaderText = "登录密码";
            this.loginPwd.Name = "loginPwd";
            this.loginPwd.Visible = false;
            // 
            // sex
            // 
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "生日";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dept
            // 
            this.dept.HeaderText = "所在部门";
            this.dept.Name = "dept";
            // 
            // post
            // 
            this.post.HeaderText = "员工职位";
            this.post.Name = "post";
            // 
            // 家庭电话
            // 
            this.家庭电话.HeaderText = "家庭电话";
            this.家庭电话.Name = "家庭电话";
            this.家庭电话.Visible = false;
            // 
            // phone
            // 
            this.phone.HeaderText = "联系电话";
            this.phone.Name = "phone";
            // 
            // address
            // 
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            this.address.Visible = false;
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mobilePhoneBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loginPwdBox);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.empAddrBox);
            this.Controls.Add(this.empNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmployeeInfoForm";
            this.Text = "EmployeeInfoForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox keyTypeBox;
        private System.Windows.Forms.ToolStripTextBox keyWordBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginName;
        private System.Windows.Forms.TextBox loginPwdBox;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.TextBox empAddrBox;
        private System.Windows.Forms.TextBox empNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox mobilePhoneBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭电话;
    }
}