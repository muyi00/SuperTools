using AndroidPictureUtils;
using CylinderArchiveRepair;
using CylinderArchiveRepair.utils;
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
    public partial class FilterLogForm : BaseForm
    {
        /// <summary>
        /// 读取的文件列表
        /// </summary>
        private List<String> filePathList = new List<String>();
        /// <summary>
        /// 读取的日志记录集合
        /// </summary>
        private List<LogInfoRow> logInfos = new List<LogInfoRow>();
        /// <summary>
        /// 芯片号统计集合
        /// </summary>
        private List<CorpXpCount> corpXpCounts = new List<CorpXpCount>();
        /// <summary>
        /// 指定的企业号
        /// </summary>
        private String appointCorpCode = "";

        public FilterLogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置所有的控件是否启用
        /// </summary>
        /// <param name="isEnabled"></param>
        private void setAllEnabled(Boolean isEnabled)
        {
            filesPath_tb.Enabled = isEnabled;
            filesPath_out_tb.Enabled = isEnabled;
            selection_path_btn.Enabled = isEnabled;
            selection_outPath_btn.Enabled = isEnabled;
            read_corpCode_tb.Enabled = isEnabled;
            isOutCorpCode.Enabled = isEnabled;
            isOnlyXpCode.Enabled = isEnabled;
            isDistinct.Enabled = isEnabled;
            read_txt_btn.Enabled = isEnabled;
            out_txt_btn.Enabled = isEnabled;
        }


        #region 读取文件路径集合


        /// <summary>
        /// 选择读取路径
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
                readFilePathList();
            }
        }

        /// <summary>
        /// 读取文件名
        /// </summary>
        private void readFilePathList()
        {
            filePathList.Clear();
            DirectoryList.GetDirectory(filesPath_tb.Text);
            foreach (string item in DirectoryList.FileList)
            {
                filePathList.Add(item);
            }
            file_name_dg.Rows.Clear();
            foreach (String name in filePathList)
            {
                String[] path = name.Split('\\');

                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(file_name_dg);
                dr.Cells[0].Value = path[path.Length - 1];
                file_name_dg.Rows.Add(dr);
            }

        }
        #endregion


        #region 遍历读取文件

        /// <summary>
        /// 遍历读取文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void read_txt_btn_Click(object sender, EventArgs e)
        {
            if (filePathList.Count == 0)
            {
                MessageBox.Show("请选择文件");
                return;
            }
            readFileList();
        }


        private void readFileList()
        {
            if (filePathList.Count == 0)
            {
                MessageBox.Show("请选择文件");
                return;
            }
            logInfos.Clear();
            corpXpCounts.Clear();
            setAllEnabled(false);

            progressBar.Value = 0;
            progressBar.Maximum = filePathList.Count;
            appointCorpCode = read_corpCode_tb.Text;

            readFile_bw.RunWorkerAsync(filePathList);
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="appointCorpCode">指定的企业号</param>
        private void rendTxt(String path, String appointCorpCode)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader streamReader = new StreamReader(fs, Encoding.Default);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (Utils.trim(line).Length == 0)
                {
                    continue;
                }
                String corpCode = "";
                String xpCode = "";

                line = Utils.trim(line.Split(']')[1]);

                if (line.IndexOf(Constant.NotRecordStr1) >= 0)
                {
                    String[] logStr = line.Split(Constant.SplitStrArray1, StringSplitOptions.RemoveEmptyEntries);

                    if (logStr.Length == 2)
                    {
                        corpCode = logStr[0];
                        xpCode = logStr[1];
                    }
                    else if (logStr.Length == 1)
                    {
                        corpCode = logStr[0];
                        xpCode = "";
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line.IndexOf(Constant.NotRecordStr2) >= 0)
                {
                    String[] logStr = line.Split(Constant.SplitStrArray2, StringSplitOptions.RemoveEmptyEntries);

                    if (logStr.Length == 2)
                    {
                        corpCode = logStr[0];
                        xpCode = logStr[1];
                    }
                    else
                    {
                        continue;
                    }

                }

                if (corpCode != null && corpCode.Length > 0)
                {
                    //读取指定企业
                    if (appointCorpCode != null && appointCorpCode.Length > 0)
                    {
                        if (Utils.trim(corpCode) != appointCorpCode)
                        {
                            continue;
                        }
                    }

                    corpCode = Utils.trim(corpCode);
                    xpCode = Utils.trim(xpCode);

                    //过滤重复
                    if (getCorpCodeXpCodeIndex(logInfos, corpCode, xpCode) < 0)
                    {
                        //添加数据
                        logInfos.Add(new LogInfoRow(corpCode, xpCode));
                        //统计数量
                        int count = 0;
                        int emptyCount = 0;
                        if (xpCode.Length > 0)
                        {
                            count = 1;
                        }
                        else
                        {
                            emptyCount = 1;
                        }
                        int index = getCorpCodeIndex(corpXpCounts, corpCode);
                        if (index >= 0)
                        {
                            //存在
                            CorpXpCount temp_CorpXpCount = corpXpCounts[index];
                            temp_CorpXpCount.count = temp_CorpXpCount.count + count;
                            temp_CorpXpCount.emptyCount = temp_CorpXpCount.emptyCount + emptyCount;
                        }
                        else
                        {
                            //不存在
                            corpXpCounts.Add(new CorpXpCount(corpCode, count, emptyCount));

                        }

                    }

                }
            }
            streamReader.Close();

            fs.Close();
        }

        /// <summary>
        /// 查询芯片号是存在
        /// </summary>
        /// <param name="logInfos">芯片信息集合</param>
        /// <param name="corpCode">企业号</param>
        /// <param name="xpCode">芯片号</param>
        /// <returns></returns>
        private int getCorpCodeXpCodeIndex(List<LogInfoRow> logInfos, String corpCode, String xpCode)
        {
            if (xpCode.Length == 0)
            {
                //空芯片不过滤，默认不存在
                return -1;
            }

            for (int i = 0; i < logInfos.Count; i++)
            {
                if (corpCode == logInfos[i].corpCode)
                {
                    if (xpCode == logInfos[i].xpCode)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// 查询企业在统计集合中是否存在
        /// </summary>
        /// <param name="corpXpCounts">统计集合</param>
        /// <param name="corpCode">企业号</param>
        /// <returns></returns>
        private int getCorpCodeIndex(List<CorpXpCount> corpXpCounts, String corpCode)
        {
            for (int i = 0; i < corpXpCounts.Count; i++)
            {

                if (corpCode == corpXpCounts[i].corpCode)
                {
                    return i;
                }
            }
            return -1;
        }

        private void setLoginfoData(List<LogInfoRow> logInfos, List<CorpXpCount> corpXpCounts)
        {
            loginfo_dg.DataSource = new List<LogInfoRow>();
            loginfo_dg.DataSource = logInfos;

            count_dg.DataSource = new List<CorpXpCount>();
            count_dg.DataSource = corpXpCounts;
        }


        private void readFile_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            List<String> filePathList = (List<String>)e.Argument;
            int count = filePathList.Count;
            for (int i = 0; i < filePathList.Count; i++)
            {
                readFile_bw.ReportProgress(i + 1);
                rendTxt(filePathList[i], appointCorpCode);
            }
        }

        private void readFile_bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            setLoginfoData(logInfos, corpXpCounts);
        }

        private void readFile_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setAllEnabled(true);
            if (e.Cancelled)
                hint_lb.Text = "任务取消。";
            else if (e.Error != null)
                hint_lb.Text = "出现异常: " + e.Error;
            else
                hint_lb.Text = "任务完成。 ";
        }

        #endregion


        #region 导出


        /// <summary>
        /// 选择导出路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selection_outPath_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filesPath_out_tb.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 获取导出文件名称
        /// </summary>
        /// <param name="corpCode"></param>
        /// <param name="isOutCorpCode"></param>
        /// <returns></returns>
        private String getFileNmae(String corpCode, Boolean isOutCorpCode)
        {
            String dateStr = DateTime.Now.ToString("yyyyMMdd");
            String fileNmae = "";
            if (isOutCorpCode || (corpCode != null && corpCode.Length > 0))
            {
                fileNmae = corpCode + "_" + dateStr + ".txt";
            }
            else
            {
                fileNmae = dateStr + ".txt";
            }

            return filesPath_out_tb.Text + "/" + fileNmae;
        }

        /// <summary>
        /// 导出文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void out_txt_btn_Click(object sender, EventArgs e)
        {
            if (filesPath_out_tb.Text.Length == 0)
            {
                MessageBox.Show("请选择导出路径");
                return;
            }

            if (isOutCorpCode.Checked)
            {
                foreach (CorpXpCount item in corpXpCounts)
                {
                    String corpCode = item.corpCode;

                    List<LogInfoRow> temp_logInfos = new List<LogInfoRow>();
                    temp_logInfos.Clear();
                    foreach (LogInfoRow row in logInfos)
                    {
                        if (corpCode == row.corpCode)
                        {
                            temp_logInfos.Add(row);
                        }

                    }

                    TxtUtils.writeTxt(getFileNmae(corpCode, true), temp_logInfos, isOnlyXpCode.Checked);

                }
            }
            else
            {
                TxtUtils.writeTxt(getFileNmae("", false), logInfos, isOnlyXpCode.Checked);
            }
            MessageBox.Show("导出成功");

        }

        #endregion








    }
}
