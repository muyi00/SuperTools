using SuperTools.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperTools
{
    public partial class CreateRecordForm : BaseForm
    {
        public CreateRecordForm()
        {
            InitializeComponent();
        }

        private void selection_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx | xls files (*.xls)|*.xls | All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath_tb.Text = openFileDialog1.FileName;          //显示文件路径
                xp_gp_dg.DataSource = ExcelUtils.ExcelToDataTable(filePath_tb.Text, false);
            }
        }






        /// <summary>  
        /// 读取Excel文件到DataSet中  
        /// </summary>  
        /// <param name="filePath">文件路径</param>  
        /// <returns></returns>  
        public  DataSet ToDataTable(string filePath)
        {
            return null;
        }

    }
}
