namespace WindowsFormsApp1
{
    partial class CompanyInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.companyAddrBox = new System.Windows.Forms.TextBox();
            this.companyPhoneBox = new System.Windows.Forms.TextBox();
            this.companyDirectorBox = new System.Windows.Forms.TextBox();
            this.companyFaxBox = new System.Windows.Forms.TextBox();
            this.companyRemarkBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.keyTypeBox = new System.Windows.Forms.ToolStripComboBox();
            this.keyWordBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "供应商名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "负责人姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "传真：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "备注：";
            // 
            // companyNameBox
            // 
            this.companyNameBox.Location = new System.Drawing.Point(141, 51);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.ReadOnly = true;
            this.companyNameBox.Size = new System.Drawing.Size(230, 25);
            this.companyNameBox.TabIndex = 7;
            // 
            // companyAddrBox
            // 
            this.companyAddrBox.Location = new System.Drawing.Point(141, 167);
            this.companyAddrBox.Multiline = true;
            this.companyAddrBox.Name = "companyAddrBox";
            this.companyAddrBox.ReadOnly = true;
            this.companyAddrBox.Size = new System.Drawing.Size(230, 106);
            this.companyAddrBox.TabIndex = 8;
            // 
            // companyPhoneBox
            // 
            this.companyPhoneBox.Location = new System.Drawing.Point(141, 115);
            this.companyPhoneBox.Name = "companyPhoneBox";
            this.companyPhoneBox.ReadOnly = true;
            this.companyPhoneBox.Size = new System.Drawing.Size(230, 25);
            this.companyPhoneBox.TabIndex = 9;
            // 
            // companyDirectorBox
            // 
            this.companyDirectorBox.Location = new System.Drawing.Point(491, 48);
            this.companyDirectorBox.Name = "companyDirectorBox";
            this.companyDirectorBox.ReadOnly = true;
            this.companyDirectorBox.Size = new System.Drawing.Size(233, 25);
            this.companyDirectorBox.TabIndex = 10;
            // 
            // companyFaxBox
            // 
            this.companyFaxBox.Location = new System.Drawing.Point(491, 112);
            this.companyFaxBox.Name = "companyFaxBox";
            this.companyFaxBox.ReadOnly = true;
            this.companyFaxBox.Size = new System.Drawing.Size(233, 25);
            this.companyFaxBox.TabIndex = 11;
            // 
            // companyRemarkBox
            // 
            this.companyRemarkBox.Location = new System.Drawing.Point(491, 169);
            this.companyRemarkBox.Multiline = true;
            this.companyRemarkBox.Name = "companyRemarkBox";
            this.companyRemarkBox.ReadOnly = true;
            this.companyRemarkBox.Size = new System.Drawing.Size(233, 106);
            this.companyRemarkBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyID,
            this.companyName,
            this.direcotor,
            this.phone,
            this.address,
            this.fax,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(41, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(705, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // companyID
            // 
            this.companyID.HeaderText = "编号";
            this.companyID.Name = "companyID";
            // 
            // companyName
            // 
            this.companyName.HeaderText = "供应商名称";
            this.companyName.Name = "companyName";
            // 
            // direcotor
            // 
            this.direcotor.HeaderText = "负责人";
            this.direcotor.Name = "direcotor";
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
            // 
            // fax
            // 
            this.fax.HeaderText = "传真";
            this.fax.Name = "fax";
            this.fax.Visible = false;
            // 
            // remark
            // 
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.Visible = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(876, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 25);
            this.toolStripLabel1.Text = "查询条件：";
            // 
            // keyTypeBox
            // 
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
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 25);
            this.updateButton.Text = "修改";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 25);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CompanyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.companyRemarkBox);
            this.Controls.Add(this.companyFaxBox);
            this.Controls.Add(this.companyDirectorBox);
            this.Controls.Add(this.companyPhoneBox);
            this.Controls.Add(this.companyAddrBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CompanyInfoForm";
            this.Text = "供应商信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox companyAddrBox;
        private System.Windows.Forms.TextBox companyPhoneBox;
        private System.Windows.Forms.TextBox companyDirectorBox;
        private System.Windows.Forms.TextBox companyFaxBox;
        private System.Windows.Forms.TextBox companyRemarkBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox keyTypeBox;
        private System.Windows.Forms.ToolStripTextBox keyWordBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton exitButton;
    }
}