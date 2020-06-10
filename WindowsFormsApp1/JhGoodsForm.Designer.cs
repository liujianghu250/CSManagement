namespace WindowsFormsApp1
{
    partial class JhGoodsForm
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
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtJhCompName = new System.Windows.Forms.TextBox();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsJhPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsSellPrice = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtGoodsNeedPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsNoPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGoodsTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.txtGoodsUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.keyType = new System.Windows.Forms.ToolStripComboBox();
            this.keyText = new System.Windows.Forms.ToolStripTextBox();
            this.queryButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(150, 47);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsID.TabIndex = 0;
            this.txtGoodsID.TextChanged += new System.EventHandler(this.txtGoodsID_TextChanged);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(540, 47);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsName.TabIndex = 1;
            // 
            // txtJhCompName
            // 
            this.txtJhCompName.Location = new System.Drawing.Point(150, 97);
            this.txtJhCompName.Name = "txtJhCompName";
            this.txtJhCompName.Size = new System.Drawing.Size(200, 25);
            this.txtJhCompName.TabIndex = 2;
            this.txtJhCompName.TextChanged += new System.EventHandler(this.txtJhCompName_TextChanged);
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(540, 97);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsNum.TabIndex = 3;
            this.txtGoodsNum.TextChanged += new System.EventHandler(this.txtGoodsNum_TextChanged);
            // 
            // txtGoodsJhPrice
            // 
            this.txtGoodsJhPrice.Location = new System.Drawing.Point(150, 197);
            this.txtGoodsJhPrice.Name = "txtGoodsJhPrice";
            this.txtGoodsJhPrice.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsJhPrice.TabIndex = 4;
            this.txtGoodsJhPrice.TextChanged += new System.EventHandler(this.txtGoodsJhPrice_TextChanged);
            // 
            // txtGoodsSellPrice
            // 
            this.txtGoodsSellPrice.Location = new System.Drawing.Point(540, 197);
            this.txtGoodsSellPrice.Name = "txtGoodsSellPrice";
            this.txtGoodsSellPrice.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsSellPrice.TabIndex = 5;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(540, 247);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(200, 25);
            this.txtEmpID.TabIndex = 6;
            // 
            // txtGoodsNeedPrice
            // 
            this.txtGoodsNeedPrice.Enabled = false;
            this.txtGoodsNeedPrice.Location = new System.Drawing.Point(150, 297);
            this.txtGoodsNeedPrice.Name = "txtGoodsNeedPrice";
            this.txtGoodsNeedPrice.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsNeedPrice.TabIndex = 7;
            // 
            // txtGoodsNoPrice
            // 
            this.txtGoodsNoPrice.Location = new System.Drawing.Point(540, 297);
            this.txtGoodsNoPrice.Name = "txtGoodsNoPrice";
            this.txtGoodsNoPrice.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsNoPrice.TabIndex = 8;
            // 
            // txtGoodsRemark
            // 
            this.txtGoodsRemark.Location = new System.Drawing.Point(150, 347);
            this.txtGoodsRemark.Name = "txtGoodsRemark";
            this.txtGoodsRemark.Size = new System.Drawing.Size(590, 25);
            this.txtGoodsRemark.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "进货编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "商品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "供应商名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "进货数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "进货单价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "销售单价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "进货员：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "应付金额：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "实付金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "备注：";
            // 
            // txtGoodsTime
            // 
            this.txtGoodsTime.Enabled = false;
            this.txtGoodsTime.Location = new System.Drawing.Point(150, 247);
            this.txtGoodsTime.Name = "txtGoodsTime";
            this.txtGoodsTime.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsTime.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "进货时间：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "所属仓库：";
            // 
            // txtDepotName
            // 
            this.txtDepotName.Location = new System.Drawing.Point(150, 147);
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.Size = new System.Drawing.Size(200, 25);
            this.txtDepotName.TabIndex = 24;
            // 
            // txtGoodsUnit
            // 
            this.txtGoodsUnit.Location = new System.Drawing.Point(540, 147);
            this.txtGoodsUnit.Name = "txtGoodsUnit";
            this.txtGoodsUnit.Size = new System.Drawing.Size(200, 25);
            this.txtGoodsUnit.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(450, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "计量单位：";
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
            this.keyType,
            this.keyText,
            this.queryButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 28);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.保存图标;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 25);
            this.saveButton.Text = "保存";
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::WindowsFormsApp1.Properties.Resources.取消;
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 25);
            this.cancelButton.Text = "清除";
            this.cancelButton.ToolTipText = "清除";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::WindowsFormsApp1.Properties.Resources.删除;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 25);
            this.deleteButton.Text = "删除";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = global::WindowsFormsApp1.Properties.Resources.添加;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 25);
            this.addButton.Text = "添加";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Image = global::WindowsFormsApp1.Properties.Resources.修改;
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 25);
            this.updateButton.Text = "修改";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 25);
            this.toolStripLabel1.Text = "查询条件:";
            // 
            // keyType
            // 
            this.keyType.Items.AddRange(new object[] {
            "商品编号",
            "商品名称",
            "供应商名称",
            "进货员",
            "仓库"});
            this.keyType.Name = "keyType";
            this.keyType.Size = new System.Drawing.Size(121, 28);
            this.keyType.Text = "商品编号";
            this.keyType.Click += new System.EventHandler(this.keyType_Click);
            // 
            // keyText
            // 
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(100, 28);
            // 
            // queryButton
            // 
            this.queryButton.Image = global::WindowsFormsApp1.Properties.Resources.查找;
            this.queryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(63, 25);
            this.queryButton.Text = "查询";
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::WindowsFormsApp1.Properties.Resources.退出;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 25);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 197);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // JhGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGoodsUnit);
            this.Controls.Add(this.txtDepotName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGoodsTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoodsRemark);
            this.Controls.Add(this.txtGoodsNoPrice);
            this.Controls.Add(this.txtGoodsNeedPrice);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtGoodsSellPrice);
            this.Controls.Add(this.txtGoodsJhPrice);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.txtJhCompName);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsID);
            this.Name = "JhGoodsForm";
            this.Text = "JhGoodsForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtJhCompName;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsJhPrice;
        private System.Windows.Forms.TextBox txtGoodsSellPrice;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtGoodsNeedPrice;
        private System.Windows.Forms.TextBox txtGoodsNoPrice;
        private System.Windows.Forms.TextBox txtGoodsRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtGoodsTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.TextBox txtGoodsUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox keyType;
        private System.Windows.Forms.ToolStripTextBox keyText;
        private System.Windows.Forms.ToolStripButton queryButton;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}