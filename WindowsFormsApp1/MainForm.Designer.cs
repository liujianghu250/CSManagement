namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsPurchaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellGoodsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnGoodsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存报警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataRecoveryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBackupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.进货管理ToolStripMenuItem,
            this.销售管理MToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.系统维护ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenuItem,
            this.companyMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 24);
            this.toolStripMenuItem1.Text = "档案管理[&B]";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.employeeMenuItem.Text = "员工信息[&E]";
            this.employeeMenuItem.Click += new System.EventHandler(this.employeeMenuItem_Click);
            // 
            // companyMenuItem
            // 
            this.companyMenuItem.Name = "companyMenuItem";
            this.companyMenuItem.Size = new System.Drawing.Size(181, 26);
            this.companyMenuItem.Text = "供应商信息[&Q]";
            this.companyMenuItem.Click += new System.EventHandler(this.companyMenuItem_Click);
            // 
            // 进货管理ToolStripMenuItem
            // 
            this.进货管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsPurchaseMenuItem,
            this.GoodsInfoMenuItem});
            this.进货管理ToolStripMenuItem.Name = "进货管理ToolStripMenuItem";
            this.进货管理ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.进货管理ToolStripMenuItem.Text = "进货管理[&C]";
            this.进货管理ToolStripMenuItem.Click += new System.EventHandler(this.进货管理ToolStripMenuItem_Click);
            // 
            // goodsPurchaseMenuItem
            // 
            this.goodsPurchaseMenuItem.Name = "goodsPurchaseMenuItem";
            this.goodsPurchaseMenuItem.Size = new System.Drawing.Size(163, 26);
            this.goodsPurchaseMenuItem.Text = "商品进货[&S]";
            this.goodsPurchaseMenuItem.Click += new System.EventHandler(this.goodsPurchaseMenuItem_Click);
            // 
            // GoodsInfoMenuItem
            // 
            this.GoodsInfoMenuItem.Name = "GoodsInfoMenuItem";
            this.GoodsInfoMenuItem.Size = new System.Drawing.Size(163, 26);
            this.GoodsInfoMenuItem.Text = "商品查询[&F]";
            this.GoodsInfoMenuItem.Click += new System.EventHandler(this.GoodsInfoMenuItem_Click);
            // 
            // 销售管理MToolStripMenuItem
            // 
            this.销售管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellGoodsMenuItem,
            this.ReturnGoodsMenuItem});
            this.销售管理MToolStripMenuItem.Name = "销售管理MToolStripMenuItem";
            this.销售管理MToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.销售管理MToolStripMenuItem.Text = "销售管理[&S]";
            // 
            // SellGoodsMenuItem
            // 
            this.SellGoodsMenuItem.Name = "SellGoodsMenuItem";
            this.SellGoodsMenuItem.Size = new System.Drawing.Size(216, 26);
            this.SellGoodsMenuItem.Text = "商品销售[&G]";
            this.SellGoodsMenuItem.Click += new System.EventHandler(this.SellGoodsMenuItem_Click);
            // 
            // ReturnGoodsMenuItem
            // 
            this.ReturnGoodsMenuItem.Name = "ReturnGoodsMenuItem";
            this.ReturnGoodsMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ReturnGoodsMenuItem.Text = "商品退货[&O]";
            this.ReturnGoodsMenuItem.Click += new System.EventHandler(this.ReturnGoodsMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存查询ToolStripMenuItem,
            this.库存报警ToolStripMenuItem});
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.库存管理ToolStripMenuItem.Text = "库存管理[&D]";
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.库存查询ToolStripMenuItem.Text = "库存查询[&M]";
            this.库存查询ToolStripMenuItem.Click += new System.EventHandler(this.库存查询ToolStripMenuItem_Click);
            // 
            // 库存报警ToolStripMenuItem
            // 
            this.库存报警ToolStripMenuItem.Name = "库存报警ToolStripMenuItem";
            this.库存报警ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.库存报警ToolStripMenuItem.Text = "库存报警[&J]";
            this.库存报警ToolStripMenuItem.Click += new System.EventHandler(this.库存报警ToolStripMenuItem_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataBackupMenuItem,
            this.DataRecoveryMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // DataRecoveryMenuItem
            // 
            this.DataRecoveryMenuItem.Name = "DataRecoveryMenuItem";
            this.DataRecoveryMenuItem.Size = new System.Drawing.Size(216, 26);
            this.DataRecoveryMenuItem.Text = "数据恢复";
            // 
            // DataBackupMenuItem
            // 
            this.DataBackupMenuItem.Name = "DataBackupMenuItem";
            this.DataBackupMenuItem.Size = new System.Drawing.Size(216, 26);
            this.DataBackupMenuItem.Text = "数据备份";
            this.DataBackupMenuItem.Click += new System.EventHandler(this.DataBackupMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "主窗口";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsPurchaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellGoodsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnGoodsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存报警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBackupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataRecoveryMenuItem;
    }
}

