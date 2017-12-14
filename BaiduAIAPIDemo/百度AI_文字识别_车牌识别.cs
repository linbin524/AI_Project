using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Common;
using AOP.Common.WinForm;
using Baidu.Aip.API;
using BaiduAIAPI;

namespace BaiduAIAPIDemo
{
    public partial class 百度AI_文字识别_车牌识别 : Form
    {
        public 百度AI_文字识别_车牌识别()
        {
            InitializeComponent();
        }

        private void btn_UploadPic_Click(object sender, EventArgs e)
        {
            UploadPicToPictureBoxHelper.UploadPic(this.pic_CarId, this.openFileDialog1);
        }




        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pic_CarId.ImageLocation))
            {

                AttrMessage.ErrorMsg("请上传图片！");

            }
            else
            {
                var result = OcrAPI.GetPlateLicense(pic_CarId.Image);
                if (result.state)
                {
                    tb_result.Text = result.contextModel.ToJson();
                }
                else {
                    tb_result.Text = result.errorMsg;
                }
               
            }

            string verificationMsg = "";

            //errorMsg = "";
            //var verifyResult = ImageVerification.VerificationImage<IDCardRecognitionModel>(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg, tempModel, out verificationMsg, out strbaser64);
            //if (!verifyResult.state)
            //{
            //    return verifyResult;
            //}
        }
    }
}
