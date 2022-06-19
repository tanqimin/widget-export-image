namespace ExcelExportImage
{
    partial class FrmApp
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
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbImgCol = new System.Windows.Forms.ComboBox();
            this.txtImgDir = new System.Windows.Forms.TextBox();
            this.btnSelectImgDir = new System.Windows.Forms.Button();
            this.fbdImgDir = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.fbdExport = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbUseSourceFileName = new System.Windows.Forms.CheckBox();
            this.cbSubDirCol = new System.Windows.Forms.ComboBox();
            this.cbSubDir = new System.Windows.Forms.CheckBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbOpenDir = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdExcel
            // 
            this.ofdExcel.Filter = "Excel文件|*.xlsx;*.xls";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(208, 66);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.ReadOnly = true;
            this.txtExcel.Size = new System.Drawing.Size(581, 28);
            this.txtExcel.TabIndex = 0;
            this.txtExcel.TabStop = false;
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(795, 66);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(66, 32);
            this.btnSelectExcel.TabIndex = 1;
            this.btnSelectExcel.Text = "选择";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片所在的列";
            // 
            // cbImgCol
            // 
            this.cbImgCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImgCol.FormattingEnabled = true;
            this.cbImgCol.Location = new System.Drawing.Point(208, 165);
            this.cbImgCol.Name = "cbImgCol";
            this.cbImgCol.Size = new System.Drawing.Size(581, 26);
            this.cbImgCol.TabIndex = 3;
            // 
            // txtImgDir
            // 
            this.txtImgDir.Location = new System.Drawing.Point(208, 114);
            this.txtImgDir.Name = "txtImgDir";
            this.txtImgDir.ReadOnly = true;
            this.txtImgDir.Size = new System.Drawing.Size(581, 28);
            this.txtImgDir.TabIndex = 0;
            this.txtImgDir.TabStop = false;
            // 
            // btnSelectImgDir
            // 
            this.btnSelectImgDir.Location = new System.Drawing.Point(795, 114);
            this.btnSelectImgDir.Name = "btnSelectImgDir";
            this.btnSelectImgDir.Size = new System.Drawing.Size(66, 32);
            this.btnSelectImgDir.TabIndex = 2;
            this.btnSelectImgDir.Text = "选择";
            this.btnSelectImgDir.UseVisualStyleBackColor = true;
            this.btnSelectImgDir.Click += new System.EventHandler(this.btnSelectImgDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "导出文件参数";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(208, 309);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(135, 28);
            this.txtPrefix.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(682, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(775, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 40);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "前缀";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "后缀";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(425, 309);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(136, 28);
            this.txtSuffix.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "分隔符";
            // 
            // txtSep
            // 
            this.txtSep.Location = new System.Drawing.Point(653, 309);
            this.txtSep.Name = "txtSep";
            this.txtSep.Size = new System.Drawing.Size(136, 28);
            this.txtSep.TabIndex = 6;
            this.txtSep.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Excel文件";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "原始图片目录";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(701, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "说明：本工具用于把腾讯文档收集的Excel文件与图片处理，用于快速重命名图片名称。";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbUseSourceFileName);
            this.panel1.Controls.Add(this.cbSubDirCol);
            this.panel1.Controls.Add(this.cbSubDir);
            this.panel1.Controls.Add(this.btnAddField);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSep);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtExcel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSelectExcel);
            this.panel1.Controls.Add(this.txtImgDir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSelectImgDir);
            this.panel1.Controls.Add(this.txtSuffix);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbImgCol);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrefix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 444);
            this.panel1.TabIndex = 22;
            // 
            // cbUseSourceFileName
            // 
            this.cbUseSourceFileName.AutoSize = true;
            this.cbUseSourceFileName.Location = new System.Drawing.Point(208, 267);
            this.cbUseSourceFileName.Name = "cbUseSourceFileName";
            this.cbUseSourceFileName.Size = new System.Drawing.Size(160, 22);
            this.cbUseSourceFileName.TabIndex = 25;
            this.cbUseSourceFileName.Text = "使用原始文件名";
            this.cbUseSourceFileName.UseVisualStyleBackColor = true;
            this.cbUseSourceFileName.CheckedChanged += new System.EventHandler(this.cbUseSourceFileName_CheckedChanged);
            // 
            // cbSubDirCol
            // 
            this.cbSubDirCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubDirCol.FormattingEnabled = true;
            this.cbSubDirCol.Location = new System.Drawing.Point(208, 215);
            this.cbSubDirCol.Name = "cbSubDirCol";
            this.cbSubDirCol.Size = new System.Drawing.Size(581, 26);
            this.cbSubDirCol.TabIndex = 24;
            // 
            // cbSubDir
            // 
            this.cbSubDir.AutoSize = true;
            this.cbSubDir.Location = new System.Drawing.Point(24, 217);
            this.cbSubDir.Name = "cbSubDir";
            this.cbSubDir.Size = new System.Drawing.Size(151, 22);
            this.cbSubDir.TabIndex = 23;
            this.cbSubDir.Text = "保存到子目录:";
            this.cbSubDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSubDir.UseVisualStyleBackColor = true;
            this.cbSubDir.CheckedChanged += new System.EventHandler(this.cbSubDir_CheckedChanged);
            this.cbSubDir.CheckStateChanged += new System.EventHandler(this.cbSubDir_CheckedChanged);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(24, 389);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(120, 35);
            this.btnAddField.TabIndex = 22;
            this.btnAddField.Text = "添加字段";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbOpenDir);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 68);
            this.panel2.TabIndex = 23;
            // 
            // cbOpenDir
            // 
            this.cbOpenDir.AutoSize = true;
            this.cbOpenDir.Checked = true;
            this.cbOpenDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenDir.Location = new System.Drawing.Point(24, 26);
            this.cbOpenDir.Name = "cbOpenDir";
            this.cbOpenDir.Size = new System.Drawing.Size(232, 22);
            this.cbOpenDir.TabIndex = 26;
            this.cbOpenDir.Text = "导出成功后自动打开目录";
            this.cbOpenDir.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 444);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(877, 144);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // FrmApp
            // 
            this.AcceptButton = this.btnExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 656);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 602);
            this.Name = "FrmApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片重命名工具";
            this.Load += new System.EventHandler(this.FrmApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbImgCol;
        private System.Windows.Forms.TextBox txtImgDir;
        private System.Windows.Forms.Button btnSelectImgDir;
        private System.Windows.Forms.FolderBrowserDialog fbdImgDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog fbdExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbSubDir;
        private System.Windows.Forms.ComboBox cbSubDirCol;
        private System.Windows.Forms.CheckBox cbUseSourceFileName;
        private System.Windows.Forms.CheckBox cbOpenDir;
    }
}

