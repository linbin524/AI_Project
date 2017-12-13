using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Common.WinForm;
using BaiduAIAPI.ORC_Characterbase64;

namespace BaiduAIAPIDemo
{
    public partial class 百度AI_API基础测试 : Form
    {
        public 百度AI_API基础测试()
        {
            InitializeComponent();
        }

        private void btn_GetAccessToken_Click(object sender, EventArgs e)
        {
            var temp = BaiduAIAPI.Access_Token.GetAccessToken();
            if (temp.IsSuccess)
            {
                tb_AccessToken.Text = temp.SuccessModel.access_token;

            }
            else
            {
                tb_AccessToken.Text = temp.ErrorModel.error + "||" + temp.ErrorModel.error_description;

            }



        }

        private void btn_IDCardRecognition_Click(object sender, EventArgs e)
        {

            var temp = BaiduAIAPI.Access_Token.GetAccessToken();
            if (temp.IsSuccess)
            {
                tb_AccessToken.Text = temp.SuccessModel.access_token;
                string startPath = "C:\\";
                string fileType = "图片|*.jpg;*.png;*.bmp;";

                string path = DialogHelper.OpenDialog(openFileDialog1, startPath, fileType);
                string data = "";
                string error = "";
                IDCardRecognition.GetIdcardRecognitionString(temp.SuccessModel.access_token, path, ref data, out error);
                tb_Result.Text = data;
            }
         
        }
    }
}
