﻿namespace WindowsFormsApp1
{
    partial class SellGoodsForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSellID = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtdeSellPrice = new System.Windows.Forms.TextBox();
            this.txtSellGoodsNum = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtdeSellNeedPay = new System.Windows.Forms.TextBox();
            this.txtdeSellHasPay = new System.Windows.Forms.TextBox();
            this.txtSellRemark = new System.Windows.Forms.TextBox();
            this.DaSellGoodsTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.addButton,
            this.deleteButton,
            this.updateButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.保存图标;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 24);
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Image = global::WindowsFormsApp1.Properties.Resources.取消;
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 24);
            this.cancelButton.Text = "取消";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = global::WindowsFormsApp1.Properties.Resources.添加;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 24);
            this.addButton.Text = "添加";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::WindowsFormsApp1.Properties.Resources.删除;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 24);
            this.deleteButton.Text = "删除";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Image = global::WindowsFormsApp1.Properties.Resources.修改;
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 24);
            this.updateButton.Text = "修改";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::WindowsFormsApp1.Properties.Resources.退出;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 24);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "销售ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "销售单价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "销售数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "员工：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "应付金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "实付金额：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "备注：";
            // 
            // txtSellID
            // 
            this.txtSellID.Enabled = false;
            this.txtSellID.Location = new System.Drawing.Point(92, 46);
            this.txtSellID.Name = "txtSellID";
            this.txtSellID.Size = new System.Drawing.Size(161, 22);
            this.txtSellID.TabIndex = 10;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Enabled = false;
            this.txtGoodsName.Location = new System.Drawing.Point(336, 46);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(116, 22);
            this.txtGoodsName.TabIndex = 11;
            // 
            // txtdeSellPrice
            // 
            this.txtdeSellPrice.Enabled = false;
            this.txtdeSellPrice.Location = new System.Drawing.Point(92, 141);
            this.txtdeSellPrice.Name = "txtdeSellPrice";
            this.txtdeSellPrice.Size = new System.Drawing.Size(161, 22);
            this.txtdeSellPrice.TabIndex = 13;
            // 
            // txtSellGoodsNum
            // 
            this.txtSellGoodsNum.Enabled = false;
            this.txtSellGoodsNum.Location = new System.Drawing.Point(336, 141);
            this.txtSellGoodsNum.Name = "txtSellGoodsNum";
            this.txtSellGoodsNum.Size = new System.Drawing.Size(154, 22);
            this.txtSellGoodsNum.TabIndex = 14;
            this.txtSellGoodsNum.TextChanged += new System.EventHandler(this.txtSellGoodsNum_TextChanged);
            this.txtSellGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellGoodsNum_KeyPress);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(552, 144);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(148, 22);
            this.txtEmpID.TabIndex = 15;
            // 
            // txtdeSellNeedPay
            // 
            this.txtdeSellNeedPay.Enabled = false;
            this.txtdeSellNeedPay.Location = new System.Drawing.Point(92, 239);
            this.txtdeSellNeedPay.Name = "txtdeSellNeedPay";
            this.txtdeSellNeedPay.Size = new System.Drawing.Size(161, 22);
            this.txtdeSellNeedPay.TabIndex = 16;
            // 
            // txtdeSellHasPay
            // 
            this.txtdeSellHasPay.Enabled = false;
            this.txtdeSellHasPay.Location = new System.Drawing.Point(336, 239);
            this.txtdeSellHasPay.Name = "txtdeSellHasPay";
            this.txtdeSellHasPay.Size = new System.Drawing.Size(154, 22);
            this.txtdeSellHasPay.TabIndex = 17;
            this.txtdeSellHasPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeSellHasPay_KeyPress);
            // 
            // txtSellRemark
            // 
            this.txtSellRemark.Enabled = false;
            this.txtSellRemark.Location = new System.Drawing.Point(552, 239);
            this.txtSellRemark.Name = "txtSellRemark";
            this.txtSellRemark.Size = new System.Drawing.Size(148, 22);
            this.txtSellRemark.TabIndex = 18;
            // 
            // DaSellGoodsTime
            // 
            this.DaSellGoodsTime.Enabled = false;
            this.DaSellGoodsTime.Location = new System.Drawing.Point(552, 46);
            this.DaSellGoodsTime.Name = "DaSellGoodsTime";
            this.DaSellGoodsTime.Size = new System.Drawing.Size(148, 22);
            this.DaSellGoodsTime.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(17, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "销售编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "销售单价";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "销售数量";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "销售员工";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "销售日期";
            this.Column6.Name = "Column6";
            this.Column6.Width = 110;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(452, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DaSellGoodsTime);
            this.Controls.Add(this.txtSellRemark);
            this.Controls.Add(this.txtdeSellHasPay);
            this.Controls.Add(this.txtdeSellNeedPay);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtSellGoodsNum);
            this.Controls.Add(this.txtdeSellPrice);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtSellID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SellGoodsForm";
            this.Text = "商品销售信息";
            this.Load += new System.EventHandler(this.exitButton_Load);
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
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSellID;
        public System.Windows.Forms.TextBox txtGoodsName;
        public System.Windows.Forms.TextBox txtdeSellPrice;
        private System.Windows.Forms.TextBox txtSellGoodsNum;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtdeSellNeedPay;
        private System.Windows.Forms.TextBox txtdeSellHasPay;
        private System.Windows.Forms.TextBox txtSellRemark;
        private System.Windows.Forms.DateTimePicker DaSellGoodsTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}