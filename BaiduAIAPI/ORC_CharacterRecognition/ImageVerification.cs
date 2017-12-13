using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Drawing;
//----------------------------------------------
//简介：文件操作
//
//
//作者：林滨
//----------------------------------------------
namespace BaiduAIAPI
{
    public class ImageVerification
    {
        /// <summary>
        /// 验证图片规格
        /// </summary>
        /// <param name="filePath">图片路径</param>
        /// <param name="Msg"></param>
        /// <param name="defaultImageSize">默认图片最大是4MB</param>
        /// <param name="defaultShortLength">默认最短15px</param>
        /// <param name="defaultLongLength">默认最长4096px</param>
        /// <returns>是否验证通过</returns>
        public static bool VerificationImage(string filePath, out string Msg, int defaultImageSize = 1024 * 1024 * 4, int defaultShortLength = 15, int defaultLongLength = 4096)
        {
            bool isPass = true;
            Msg = "";//提示信息

            string filename = System.IO.Path.GetFileName(filePath);


            #region 初始化验证参数
            if (!File.Exists(filePath))
            {
                return false;
            }

            if (string.IsNullOrEmpty(filename))
            {
                Msg = "文件不能为空！";
                return false;
            }

            #endregion

            #region 验证是否是图片
            bool isImg = false;//是否是图片标识
            string[] imgTypeList = new string[] { ".jpg", ".png", "bmp" };

            //得到文件后缀
            string fileType = System.IO.Path.GetExtension(filePath);

            for (int i = 0; i < imgTypeList.Count(); i++)
            {

                if (fileType.ToLower() == imgTypeList[i])
                {

                    isImg = true;
                }
            }

            if (!isImg)
            {

                Msg = "上传文件不是图片格式！请重新上传！";
                return false;
            }
            #endregion

            #region 验证图片大小

            int imgSize = defaultImageSize;
            byte[] bs = File.ReadAllBytes(filePath);


            if (bs.Length > imgSize)
            {
                Msg = "图片大小不能" + imgSize / 1024 / 1024 + "MB";
                return false;

            }
            #endregion

            #region 验证图片尺寸大小


            System.Drawing.Image tempImage = System.Drawing.Image.FromFile(filePath);

            int picWidth = tempImage.Width;
            int picHeigth = tempImage.Height;

            if (!(defaultShortLength <= picWidth && picWidth <= defaultLongLength) && (defaultShortLength <= picHeigth && picHeigth <= defaultLongLength))
            {

                Msg = "图片尺寸规格最短边至少" + defaultShortLength + "px，最长边最大" + defaultLongLength + "px,";
                return false;
            }

            #endregion

            return isPass;

        }
    }
}
