namespace WindowsFormsApp1
{
    partial class ThGoodsInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThGoodsID = new System.Windows.Forms.TextBox();
            this.txtSellID = new System.Windows.Forms.TextBox();
            this.txtThGoodsName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtThGoodsNum = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtThNeedPay = new System.Windows.Forms.TextBox();
            this.txtThHasPay = new System.Windows.Forms.TextBox();
            this.txtThGoodsResult = new System.Windows.Forms.TextBox();
            this.daThGoodsTime = new System.Windows.Forms.DateTimePicker();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
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
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
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
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "退货ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "销售ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "退货单价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "退货数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "员工：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "应付金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "已退款金额：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "退货原因：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(27, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 153);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "退货编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "退货单价";
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "退货数量";
            this.Column4.Name = "Column4";
            this.Column4.Width = 135;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "退货日期";
            this.Column5.Name = "Column5";
            this.Column5.Width = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "退货时间：";
            // 
            // txtThGoodsID
            // 
            this.txtThGoodsID.Enabled = false;
            this.txtThGoodsID.Location = new System.Drawing.Point(99, 63);
            this.txtThGoodsID.Name = "txtThGoodsID";
            this.txtThGoodsID.Size = new System.Drawing.Size(147, 22);
            this.txtThGoodsID.TabIndex = 12;
            // 
            // txtSellID
            // 
            this.txtSellID.Enabled = false;
            this.txtSellID.Location = new System.Drawing.Point(321, 63);
            this.txtSellID.Name = "txtSellID";
            this.txtSellID.Size = new System.Drawing.Size(113, 22);
            this.txtSellID.TabIndex = 13;
            // 
            // txtThGoodsName
            // 
            this.txtThGoodsName.Enabled = false;
            this.txtThGoodsName.Location = new System.Drawing.Point(560, 63);
            this.txtThGoodsName.Name = "txtThGoodsName";
            this.txtThGoodsName.Size = new System.Drawing.Size(141, 22);
            this.txtThGoodsName.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(99, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 15;
            // 
            // txtThGoodsNum
            // 
            this.txtThGoodsNum.Enabled = false;
            this.txtThGoodsNum.Location = new System.Drawing.Point(289, 140);
            this.txtThGoodsNum.Name = "txtThGoodsNum";
            this.txtThGoodsNum.Size = new System.Drawing.Size(100, 22);
            this.txtThGoodsNum.TabIndex = 16;
            this.txtThGoodsNum.TextChanged += new System.EventHandler(this.txtThGoodsNum_TextChanged);
            this.txtThGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThGoodsNum_KeyPress);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(460, 140);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(94, 22);
            this.txtEmpID.TabIndex = 17;
            // 
            // txtThNeedPay
            // 
            this.txtThNeedPay.Enabled = false;
            this.txtThNeedPay.Location = new System.Drawing.Point(99, 231);
            this.txtThNeedPay.Name = "txtThNeedPay";
            this.txtThNeedPay.Size = new System.Drawing.Size(147, 22);
            this.txtThNeedPay.TabIndex = 19;
            // 
            // txtThHasPay
            // 
            this.txtThHasPay.Enabled = false;
            this.txtThHasPay.Location = new System.Drawing.Point(341, 231);
            this.txtThHasPay.Name = "txtThHasPay";
            this.txtThHasPay.Size = new System.Drawing.Size(129, 22);
            this.txtThHasPay.TabIndex = 20;
            this.txtThHasPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThHasPay_KeyPress);
            // 
            // txtThGoodsResult
            // 
            this.txtThGoodsResult.Enabled = false;
            this.txtThGoodsResult.Location = new System.Drawing.Point(560, 210);
            this.txtThGoodsResult.Multiline = true;
            this.txtThGoodsResult.Name = "txtThGoodsResult";
            this.txtThGoodsResult.Size = new System.Drawing.Size(194, 57);
            this.txtThGoodsResult.TabIndex = 21;
            // 
            // daThGoodsTime
            // 
            this.daThGoodsTime.Enabled = false;
            this.daThGoodsTime.Location = new System.Drawing.Point(644, 140);
            this.daThGoodsTime.Name = "daThGoodsTime";
            this.daThGoodsTime.Size = new System.Drawing.Size(144, 22);
            this.daThGoodsTime.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(440, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThGoodsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daThGoodsTime);
            this.Controls.Add(this.txtThGoodsResult);
            this.Controls.Add(this.txtThHasPay);
            this.Controls.Add(this.txtThNeedPay);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtThGoodsNum);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtThGoodsName);
            this.Controls.Add(this.txtSellID);
            this.Controls.Add(this.txtThGoodsID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "ThGoodsInfoForm";
            this.Text = "商品退货信息";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThGoodsID;
        public System.Windows.Forms.TextBox txtSellID;
        public System.Windows.Forms.TextBox txtThGoodsName;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtThGoodsNum;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtThNeedPay;
        private System.Windows.Forms.TextBox txtThHasPay;
        private System.Windows.Forms.TextBox txtThGoodsResult;
        private System.Windows.Forms.DateTimePicker daThGoodsTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}