using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace CMS.Infrastructure.Tools
{
    /// <summary>
    /// 上传文件
    /// </summary>
    public class FileUtils
    {

        /// <summary>
        /// 查找是否有该文件夹，没有则创建
        /// </summary>
        public string CreateFile(string filepath)
        {
            filepath += DateTime.Now.ToString("yyyyMM");
            if (Directory.Exists(HttpContext.Current.Server.MapPath(filepath)) == false)
            {
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath(filepath));
            }
            return filepath;
        }
        /// <summary>
        /// 保存上传文件
        /// </summary>
        /// <param name="filePath">文件保存地址</param>
        /// <param name="fileContext">文件内容</param>
        /// <param name="fileType">文件类别</param>
        /// <returns></returns>
        public string SaveFile(string filePath, string fileContext, string fileType = "")
        {
            string resultPath = "";
            FileStream fileStream = null;
            try
            {
                string absPath, sFilePath = filePath;
                string fileName = Guid.NewGuid().ToString("N");
                MatchCollection mc = Regex.Matches(fileContext, @"/\w+");
                string exstenName = mc[0].ToString().Replace("/", ".");
                fileName += exstenName;
                filePath = Path.Combine(filePath, fileName);
                filePath = filePath.Replace('\\', '/');
                absPath = HttpContext.Current.Server.MapPath(filePath);
                fileContext = fileContext.Split(',')[1];
                byte[] buff = Convert.FromBase64String(fileContext);

                fileStream = new FileStream(absPath, FileMode.Create);
                fileStream.Write(buff, 0, buff.Length);

                fileStream.Close();
                fileStream.Dispose();
                string filePathLast = Path.Combine(sFilePath, "compress" + fileName);
                filePathLast = filePathLast.Replace('\\', '/');
                resultPath = filePathLast;
                filePathLast = HttpContext.Current.Server.MapPath(filePathLast);
                GetPicThumbnail(absPath, filePathLast, 100);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return resultPath;
        }
        /// <summary>
        /// 保存文件，如果路径不存在创建目录
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileContext"></param>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public static string SaveFileAndCreatePath(string filePath, string fileContext, string fileType = "")
        {
            if (!Directory.Exists(HttpContext.Current.Server.MapPath(filePath)))
            {
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath(filePath));
            }
            string resultPath = "";
            FileStream fileStream = null;
            try
            {
                string absPath, sFilePath = filePath;
                string fileName = Guid.NewGuid().ToString("N");
                MatchCollection mc = Regex.Matches(fileContext, @"/\w+");
                string exstenName = mc[0].ToString().Replace("/", ".");
                fileName += exstenName;
                filePath = Path.Combine(filePath, fileName);
                filePath = filePath.Replace('\\', '/');
                absPath = HttpContext.Current.Server.MapPath(filePath);
                fileContext = fileContext.Split(',')[1];
                byte[] buff = Convert.FromBase64String(fileContext);

                fileStream = new FileStream(absPath, FileMode.Create);
                fileStream.Write(buff, 0, buff.Length);

                fileStream.Close();
                fileStream.Dispose();
                string filePathLast = Path.Combine(sFilePath, "compress" + fileName);
                filePathLast = filePathLast.Replace('\\', '/');
                resultPath = filePathLast;
                filePathLast = HttpContext.Current.Server.MapPath(filePathLast);
                GetPicThumbnail(absPath, filePathLast, 100);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return resultPath;
        }
        /// <summary>
        /// 删除文件（上传文件后，数据处理出现异样，数据回滚的时候，需要删除文件，减少垃圾文件的产生）
        /// </summary>
        /// <param name="filePath">相对路径</param>
        public void RemoveFile(string filePath)
        {
            string sPhysicsPath = HttpContext.Current.Server.MapPath(filePath);
            if (File.Exists(sPhysicsPath))
            {
                File.Delete(sPhysicsPath);
            }
        }
        #region
        /// <summary>
        /// 无损压缩图片,不缩放
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <returns></returns>
        public static bool GetPicThumbnail(string sFile, string dFile, int flag)
        {
            Image iSource = Image.FromFile(sFile);
            ImageFormat tFormat = iSource.RawFormat;
            int sW = iSource.Width, sH = iSource.Height, dHeight = iSource.Height, dWidth = iSource.Width;

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
