using CylinderArchiveRepair.utils;
using SuperTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CylinderArchiveRepair
{
    class TxtUtils
    {



        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<LogInfoRow> rendTxt(String path,String appointCorpCode)
        {
            List<LogInfoRow> rows = new List<LogInfoRow>();
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader streamReader = new StreamReader(fs, Encoding.Default);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.Length == 0)
                {
                    continue;
                }
                String timeStr="";
                String corpCode = "";
                String xpCode = "";

                if (line.IndexOf(Constant.NotRecordStr1) >= 0)
                {
                    String[] logStr = line.Split(Constant.SplitStrArray1, StringSplitOptions.RemoveEmptyEntries);
                    
                    if (logStr.Length == 3)
                    {
                        timeStr = logStr[0];
                        corpCode = logStr[1];
                        xpCode = logStr[2];
                    }
                    else if (logStr.Length == 2)
                    {
                        timeStr = logStr[0];
                        corpCode = logStr[1];
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
                   
                    if (logStr.Length == 3)
                    {
                        timeStr = logStr[0];
                        corpCode = logStr[1];
                        xpCode = logStr[2];
                    }
                    else
                    {
                        continue;
                    }
                  
                }


                if (corpCode !=null && corpCode.Length>0)
                {
                    if (appointCorpCode!=null&& appointCorpCode.Length>0)
                    {
                        if (Utils.trim(corpCode) != appointCorpCode)
                        {
                            continue;
                        }
                    }

                    rows.Add(new LogInfoRow(Utils.trim(corpCode), Utils.trim(xpCode)));
                }
            }

            return rows;
        }


        
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fileParh"></param>
        /// <param name="infos"></param>
        public static void writeTxt(String fileParh, List<LogInfoRow> infoRows, Boolean isOnlyXpCode)
        {
            FileStream fs = new FileStream(fileParh, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs); // 创建写入流
            foreach (LogInfoRow item in infoRows)
            {
                String str = LogInfoRow.getLogInfoRow(item, isOnlyXpCode);
                if (str == null || str.Length == 0) { continue; }
                sw.WriteLine(str);
            }
            sw.Close(); //关闭文件
        }



    }
}
