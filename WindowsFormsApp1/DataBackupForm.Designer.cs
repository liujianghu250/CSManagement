namespace WindowsFormsApp1
{
    partial class DataBackupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.fileChooseButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份数据文件存放路径：";
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(229, 45);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(308, 25);
            this.filePathBox.TabIndex = 2;
            // 
            // fileChooseButton
            // 
            this.fileChooseButton.Location = new System.Drawing.Point(611, 48);
            this.fileChooseButton.Name = "fileChooseButton";
            this.fileChooseButton.Size = new System.Drawing.Size(75, 23);
            this.fileChooseButton.TabIndex = 3;
            this.fileChooseButton.Text = "浏览";
            this.fileChooseButton.UseVisualStyleBackColor = true;
            this.fileChooseButton.Click += new System.EventHandler(this.fileChooseButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(611, 105);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(75, 23);
            this.BackupButton.TabIndex = 4;
            this.BackupButton.Text = "备份";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "备份数据文件名称：";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(229, 102);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(308, 25);
            this.fileNameBox.TabIndex = 6;
            // 
            // DataBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 175);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.fileChooseButton);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.label1);
            this.Name = "DataBackupForm";
            this.Text = "DataBackupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button fileChooseButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}