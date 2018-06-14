using AndroidPictureUtils;
using CylinderArchiveRepair.utils;
using SuperTools.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SuperTools
{
    public partial class PictureName : BaseForm
    {

        private List<ResFileInfo> fileinfos = new List<ResFileInfo>();

        public PictureName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择读取图片路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selection_path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filesPath_tb.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 扫描图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scan_btn_Click(object sender, EventArgs e)
        {
            if (filesPath_tb.Text.Length <= 0)
            {
                MessageBox.Show("路径不能为空");
                return;
            }

            fileinfos.Clear();
            List<String> pathNames = getFiles(filesPath_tb.Text);
            for (int i = 0; i < pathNames.Count; i++)
            {
                String path = pathNames[i];
                ResFileInfo info = new ResFileInfo();
                info.filePath = path;
                info.fileName = getFileName(path);
                info.fileSize = Utils.GetFileSize(path);
                info.isLegal = isNameLegal(getFileName(path));
                info.newFilePath = "";
                info.newFileName = "";
                fileinfos.Add(info);
            }
            setDataGrid(fileinfos);
        }



        private bool isNameLegal(string name)
        {
            string regexStr = regexFileName_tb.Text;
            if (regexStr != null && regexStr != "")
            {
                if (!Utils.isNameLegal(name, regexStr))//^[a-z][a-z0-9_]+$
                {
                    return false;
                }

            }

            if (androidPictureName_cb.Checked)
            {
                if (!Utils.isAndroidPictureName(name))
                {
                    return false;
                }
            }

            return true;
        }

        private List<String> getFiles(string path)
        {

            List<String> pathName = new List<string>();

            DirectoryList.GetDirectory(path);
            //目录列表
            // foreach (string item in DirectoryList.DirectorysList)
            // {
            //     Console.WriteLine(item);
            // }
            //文件列表
            foreach (string item in DirectoryList.FileList)
            {
                pathName.Add(item);
            }

            return pathName;
        }



        private string getFileName(string path)
        {
            return path.Substring(path.LastIndexOf("\\") + 1);

        }

        /// <summary>
        /// 选择另存为路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newpath_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件新路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                newFilesPath_tb.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_newpath_btn_Click(object sender, EventArgs e)
        {
            if (filesPath_tb.Text.Length <= 0)
            {
                MessageBox.Show("路径不能为空");
                return;
            }

            if (newFilesPath_tb.Text.Length <= 0)
            {
                MessageBox.Show("新路径不能为空");
                return;
            }
            String newFileDir = newFilesPath_tb.Text + "\\" + filesPath_tb.Text.Substring(filesPath_tb.Text.LastIndexOf("\\") + 1);

            if (!Directory.Exists(newFileDir))
            {
                Directory.CreateDirectory(newFileDir);
            }
            for (int i = 0; i < fileinfos.Count; i++)
            {
                ResFileInfo info = fileinfos[i];
                //文件名转换
                string newName = replaceName(info.fileName);//.Replace("-","_").Replace("—", "_").Replace(" ","").Replace(" ", "").Replace("－", "_").ToLower();
                //新文件保存路径
                string newFilePath = newFileDir + "\\" + newName;
                info.newFilePath = newFilePath;
                info.newFileName = newName;
                File.Copy(info.filePath, newFilePath, true);
                info.newfileSize = Utils.GetFileSize(newFilePath);
            }
            setDataGrid(fileinfos);
        }

        /// <summary>
        /// 设置显示
        /// </summary>
        /// <param name="fileinfos"></param>
        private void setDataGrid(List<ResFileInfo> fileinfos)
        {
            filesDataGrid.Rows.Clear();
            foreach (ResFileInfo info in fileinfos)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(filesDataGrid);
                //dr.Cells[0].Value = info.filePath;
                dr.Cells[0].Value = info.fileName;
                //dr.Cells[1].Value = Utils.GetFileSize(info.filePath);
                dr.Cells[1].Value = Utils.GetFileSizeStr(info.fileSize);
                if (info.newFilePath != null && info.newFilePath != "")
                {
                    //dr.Cells[2].Value = info.newFilePath;
                    dr.Cells[2].Value = info.newFileName;
                    dr.Cells[3].Value = Utils.GetFileSizeStr(info.newfileSize);
                }
                filesDataGrid.Rows.Add(dr);
            }

            for (int i = 0; i < fileinfos.Count; i++)
            {
                if (fileinfos[i].isLegal == true)
                {
                    filesDataGrid.Rows[i].Cells[0].Style.BackColor = Color.White;
                }
                else
                {
                    filesDataGrid.Rows[i].Cells[0].Style.BackColor = Color.Red;
                }


                double fileSize = 0;
                try
                {
                    fileSize = Double.Parse(hintFileSize_tb.Text) * 1024;
                }
                catch (Exception)
                {
                    fileSize = 0;
                }
                if (fileSize > 0)
                {
                    if (fileinfos[i].fileSize < fileSize)
                    {
                        filesDataGrid.Rows[i].Cells[1].Style.BackColor = Color.White;
                    }
                    else
                    {
                        filesDataGrid.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    }
                }


            }

        }

        private void filesDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (col == 0)
            {
                ResFileInfo info = fileinfos[row];
                if (!File.Exists(info.filePath))
                {
                    return;
                }
                System.Diagnostics.Process.Start(info.filePath);
            }
        }



        private string replaceName(string fileName)
        {
            String replaceStr = replaceName_tb.Text;
            if (replaceStr != null || replaceStr.Length > 0)
            {
                String[] replaceStrs = replaceStr.Split(';');
                foreach (string item in replaceStrs)
                {
                    String[] ss = item.Split(',');
                    fileName = fileName.Replace(ss[0], ss[1]);
                }
            }

            if (fileNameToLower_cb.Checked)
            {
                fileName = fileName.ToLower();
            }

            return fileName;

        }
    }
}
