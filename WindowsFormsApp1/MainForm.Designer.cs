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
            this.companyMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyMenu
            // 
            this.companyMenu.Location = new System.Drawing.Point(12, 12);
            this.companyMenu.Name = "companyMenu";
            this.companyMenu.Size = new System.Drawing.Size(103, 44);
            this.companyMenu.TabIndex = 0;
            this.companyMenu.Text = "供应商信息";
            this.companyMenu.UseVisualStyleBackColor = true;
            this.companyMenu.Click += new System.EventHandler(this.companyMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyMenu);
            this.Name = "MainForm";
            this.Text = "主窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button companyMenu;
    }
}

