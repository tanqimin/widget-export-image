using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work.MyFavs.Tools;

namespace ExcelExportImage
{
    public partial class FrmApp : Form
    {
        private ICollection<string> _columns;

        public FrmApp()
        {
            InitializeComponent();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            if(ofdExcel.ShowDialog() == DialogResult.OK)
            {
                txtExcel.Text = ofdExcel.FileName;
                _columns = MiniExcel.GetColumns(txtExcel.Text, useHeaderRow: true);
                cbImgCol.Items.Clear();
                cbSubDirCol.Items.Clear();
                foreach (var col in _columns)
                {
                    cbImgCol.Items.Add(col);
                    cbSubDirCol.Items.Add(col);
                }
            } 
        }

        private void btnSelectImgDir_Click(object sender, EventArgs e)
        {
            if(fbdImgDir.ShowDialog() == DialogResult.OK)
            {
                txtImgDir.Text = fbdImgDir.SelectedPath;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtExcel.Text = String.Empty;
            txtImgDir.Text= String.Empty;
            cbImgCol.Items.Clear ();
            cbSubDirCol.Items.Clear();
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //前缀、后缀、分隔符
            string prefix, suffix, sep;
            //是否保存到子目录
            bool useSubDir;
            
            prefix = txtPrefix.Text.Trim();
            suffix = txtSuffix.Text.Trim();
            sep = txtSep.Text;
            useSubDir = cbSubDir.Checked;

            if (useSubDir == false && flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("至少设置一个导出列作为文件名变量", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> ucFieldValues = GetUcFieldValues();

            if (fbdExport.ShowDialog() == DialogResult.OK)
            {
                var excelPath = txtExcel.Text;
                var exportPath = fbdExport.SelectedPath;

                var table = MiniExcel.QueryAsDataTable(excelPath, useHeaderRow: true);
                var rows = table.Rows;
                foreach (DataRow row in rows)
                {
                    //图片列内容
                    string pathCol = row[cbImgCol.Text].ToString().Trim();
                    //子目录名称
                    var subDirName = row[cbSubDirCol.Text].ToString().Trim();

                    if (pathCol == null || pathCol.Length == 0)
                        continue;

                    string sourceFileName = pathCol.Replace("/", "-").Replace(":", "-");
                    string sourceFilePath = txtImgDir.Text + "\\" + sourceFileName;
                    if (!File.Exists(sourceFilePath))
                        continue;

                    StringBuilder exportFilePath = new StringBuilder();
                    exportFilePath.Append(exportPath);
                    exportFilePath.Append("\\");

                    if (useSubDir)
                    {
                        exportFilePath.Append(subDirName);
                        exportFilePath.Append("\\");
                        if (!Directory.Exists(exportFilePath.ToString()))
                        {
                            Directory.CreateDirectory(exportFilePath.ToString());
                        }
                    }

                    if (cbUseSourceFileName.Checked)
                    {
                        exportFilePath.Append(sourceFileName);
                    } 
                    else
                    {
                        if (prefix.Length > 0)
                        {
                            exportFilePath.Append(prefix);
                            exportFilePath.Append(sep);
                        }

                        foreach (var ucFieldValue in ucFieldValues)
                        {
                            exportFilePath.Append(row[ucFieldValue].ToString().Trim());
                            exportFilePath.Append(sep);
                        }

                        if (suffix.Length > 0)
                        {
                            exportFilePath.Append(suffix);
                        }
                        else
                        {
                            if (exportFilePath.ToString().Substring(exportFilePath.Length - 1, 1) == sep)
                                exportFilePath.Remove(exportFilePath.Length - 1, 1);
                        }

                        exportFilePath.Append(Path.GetExtension(sourceFilePath));
                    }


                    File.Copy(sourceFilePath, exportFilePath.ToString(), true);
                }
                if (MessageBox.Show("导出完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if(cbOpenDir.Checked)
                        System.Diagnostics.Process.Start("explorer.exe", exportPath);
                }
                    
            }

        }

        private List<string> GetUcFieldValues()
        {
            return flowLayoutPanel1.Controls.Cast<UcField>()
                .Where(x => x.Value != null && x.Value.Length > 0)
                .Select(x => x.Value).ToList();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            UcField ucField = new UcField(_columns);
            ucField.DeleteField += UcField_DeleteField;
            flowLayoutPanel1.Controls.Add(ucField);
        }

        private void UcField_DeleteField(object sender, EventArgs e)
        {
            if(sender is UcField ucField)
            {
                flowLayoutPanel1.Controls.Remove(ucField);
            }
        }

        private void FrmApp_Load(object sender, EventArgs e)
        {
            this.cbSubDir_CheckedChanged(sender, e);
            this.cbUseSourceFileName_CheckedChanged(sender, e);
        }

        private void cbSubDir_CheckedChanged(object sender, EventArgs e)
        {
            this.cbSubDirCol.Enabled = this.cbSubDir.Checked;
        }

        private void cbUseSourceFileName_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPrefix.Enabled = !this.cbUseSourceFileName.Checked;
            this.txtSuffix.Enabled = !this.cbUseSourceFileName.Checked;
            this.txtSep.Enabled = !this.cbUseSourceFileName.Checked;
            this.btnAddField.Enabled = !this.cbUseSourceFileName.Checked;
        }
    }
}
