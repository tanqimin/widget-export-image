namespace Work.MyFavs.Tools
{
    partial class UcField
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCol1 = new System.Windows.Forms.ComboBox();
            this.lldel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbCol1
            // 
            this.cbCol1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCol1.FormattingEnabled = true;
            this.cbCol1.Location = new System.Drawing.Point(0, 6);
            this.cbCol1.Name = "cbCol1";
            this.cbCol1.Size = new System.Drawing.Size(140, 26);
            this.cbCol1.TabIndex = 8;
            // 
            // lldel
            // 
            this.lldel.AutoSize = true;
            this.lldel.Location = new System.Drawing.Point(148, 10);
            this.lldel.Name = "lldel";
            this.lldel.Size = new System.Drawing.Size(17, 18);
            this.lldel.TabIndex = 9;
            this.lldel.TabStop = true;
            this.lldel.Text = "X";
            this.lldel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
            // 
            // UcField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCol1);
            this.Controls.Add(this.lldel);
            this.Name = "UcField";
            this.Size = new System.Drawing.Size(165, 40);
            this.Load += new System.EventHandler(this.UcField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCol1;
        private System.Windows.Forms.LinkLabel lldel;
    }
}
