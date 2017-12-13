using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Common;
using Baidu.Aip.API;

namespace BaiduAIAPIDemo
{
    public partial class 百度AI_文字识别_验证码识别 : Form
    {
        public 百度AI_文字识别_验证码识别()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pb_verifyCode.Image != null) {
                       
              tb_Result.Text= "通用版："+ OcrAPI.GeneralBasic(pb_verifyCode.Image);
                tb_Result.Text+="\r\n高精度版："+ OcrAPI.Accurate(pb_verifyCode.Image);
              
            }
        }

        private void btn_downloadVerifyCodeImage_Click(object sender, EventArgs e)
        {
            //识别效果精准度差
           pb_verifyCode.Image= HttpRequestHelper.DowmloadToImage("https://api.srv.jpush.cn/v1/captcha/1513149415328/?type=login&uuid=926bcff6-05cb-42c8-8df5-7698218d2b47");
        }
    }
}
