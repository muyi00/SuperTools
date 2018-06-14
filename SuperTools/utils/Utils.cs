using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CylinderArchiveRepair.utils
{
    class Utils
    {

        public static String trim(String str)
        {
            return str.Trim().Replace("\"", "").Replace("\t", " ");
        }


        ///////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 使DataGridView的列自适应宽度
        /// </summary>
        /// <param name="dgViewFiles"></param>
        public static void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            //dgViewFiles.Columns[0].Frozen = false;
            //dgViewFiles.Columns[1].Frozen = true;
            //dgViewFiles.Columns[2].Frozen = true;
            //dgViewFiles.Columns[3].Frozen = false;
        }

        /// <summary>
        /// 判断文件名是否合法
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool isNameLegal(string name, string pattern)
        {
            name = name.Substring(0, name.Length - 4);
            // string pattern = @"^[a-z][a-z0-9_]+$";
            return Regex.IsMatch(name, pattern);
        }

        /// <summary>
        /// 判断是否为合法的android图片文件名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool isAndroidPictureName(string name)
        {
            String[] names = name.Split('.');
            if (names.Length == 3)
            {
                if (name.Split('.')[1] != "9")
                {
                    return false;
                }
            }

            //不允许大写字母
            if (!isNameLegal(name, @"^[a-z0-9_.]+$"))
            {
                return false;
            }

            //不允许以关键字为名
            List<String> javaKeywords = getJavaKeywords();
            if (javaKeywords.IndexOf(name) > 0)
            {
                return false;
            }

            //不允许以下划线（"_"）开头
            if (name.StartsWith("_"))
            {
                return false;
            }

            //不允许以数字加下划线（"[0-9]_"）开头
            if (isNameLegal(name, @"^[0-9]_+$"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取java关键字
        /// </summary>
        /// <returns></returns>
        private static List<String> getJavaKeywords()
        {
            List<String> keywords = new List<string>();
            keywords.Add("abstract");
            keywords.Add("continue");
            keywords.Add("for");
            keywords.Add("new");
            keywords.Add("switch");
            keywords.Add("assert");
            keywords.Add("default");
            keywords.Add("goto");
            keywords.Add("package");
            keywords.Add("synchronized");
            keywords.Add("boolean");
            keywords.Add("do");
            keywords.Add("if");
            keywords.Add("private");
            keywords.Add("this");
            keywords.Add("break");
            keywords.Add("double");
            keywords.Add("implements");
            keywords.Add("protected");
            keywords.Add("throw");
            keywords.Add("byte");
            keywords.Add("else");
            keywords.Add("import");
            keywords.Add("public");
            keywords.Add("throws");
            keywords.Add("case");
            keywords.Add("enum");
            keywords.Add("instanceof");
            keywords.Add("return");
            keywords.Add("transient");
            keywords.Add("catch");
            keywords.Add("extends");
            keywords.Add("int");
            keywords.Add("short");
            keywords.Add("try");
            keywords.Add("char");
            keywords.Add("final");
            keywords.Add("interface");
            keywords.Add("static");
            keywords.Add("void");
            keywords.Add("class");
            keywords.Add("finally");
            keywords.Add("long");
            keywords.Add("strictfp");
            keywords.Add("volatile");
            keywords.Add("const");
            keywords.Add("float");
            keywords.Add("native");
            keywords.Add("super");
            keywords.Add("while");
            return keywords;
        }



        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="sFileFullName"></param>
        /// <returns>B</returns>
        public static double GetFileSize(string sFileFullName)
        {
            FileInfo fiInput = new FileInfo(sFileFullName);
            return fiInput.Length;
        }

        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="sFileFullName"></param>
        /// <returns>B, KB, MB, GB</returns>
        public static string GetFileSizeStr(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            string filesize = String.Format("{0:0.##} {1}", len, sizes[order]);
            return filesize;
        }


        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="sFileFullName"></param>
        /// <returns>B, KB, MB, GB</returns>
        public static string GetFileSizeStr(string sFileFullName)
        {
            return GetFileSizeStr(GetFileSize(sFileFullName));
        }


        #region GetPicThumbnail
        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth">宽度</param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <returns></returns>

        public bool GetPicThumbnail(string sFile, string dFile, int dHeight, int dWidth, int flag)
        {
            System.Drawing.Image iSource = System.Drawing.Image.FromFile(sFile);

            ImageFormat tFormat = iSource.RawFormat;

            int sW = 0, sH = 0;

            //按比例缩放

            Size tem_size = new Size(iSource.Width, iSource.Height);



            if (tem_size.Width > dHeight || tem_size.Width > dWidth) //将**改成c#中的或者操作符号
            {

                if ((tem_size.Width * dHeight) > (tem_size.Height * dWidth))
                {

                    sW = dWidth;

                    sH = (dWidth * tem_size.Height) / tem_size.Width;

                }

                else
                {

                    sH = dHeight;

                    sW = (tem_size.Width * dHeight) / tem_size.Height;

                }

            }

            else
            {

                sW = tem_size.Width;

                sH = tem_size.Height;

            }

            Bitmap ob = new Bitmap(dWidth, dHeight);

            Graphics g = Graphics.FromImage(ob);

            g.Clear(Color.WhiteSmoke);

            g.CompositingQuality = CompositingQuality.HighQuality;

            g.SmoothingMode = SmoothingMode.HighQuality;

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);

            g.Dispose();

            //以下代码为保存图片时，设置压缩质量

            EncoderParameters ep = new EncoderParameters();

            long[] qy = new long[1];

            qy[0] = flag;//设置压缩的比例1-100

            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);

            ep.Param[0] = eParam;

            try
            {

                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();

                ImageCodecInfo jpegICIinfo = null;

                for (int x = 0; x < arrayICI.Length; x++)
                {

                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {

                        jpegICIinfo = arrayICI[x];

                        break;

                    }

                }

                if (jpegICIinfo != null)
                {

                    ob.Save(dFile, jpegICIinfo, ep);//dFile是压缩后的新路径

                }

                else
                {

                    ob.Save(dFile, tFormat);

                }

                return true;

            }

            catch
            {

                return false;

            }

            finally
            {

                iSource.Dispose();

                ob.Dispose();

            }



        }
        #endregion
    }


}
