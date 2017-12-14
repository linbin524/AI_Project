using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Common;
using AOP.Common.WinForm;
using AOP.WinFormPlugin;
using BaiduAIAPI.Model;
using BaiduAIAPI.ORC_Characterbase64;

namespace BaiduAI_ORC_CharacterRecognitionPlugin
{
    public partial class Form_IDCardRecognition : FormInit
    {
        public static string picPath = "";
        public Thread t1;


        public Form_IDCardRecognition()
        {
            InitializeComponent();
            base.PBar = this.toolStrip1;
        }



        private void Form_IDCardRecognition_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 上传正面图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPic_Click(object sender, EventArgs e)
        {

            UploadPic(pb_PositivePic);

        }

        public void UploadPic(PictureBox picbox)
        {

            try
            {
                string startPath = "C:\\";
                string fileType = "图片|*.jpg;*.png;*.bmp;";

                string filePath = DialogHelper.OpenDialog(openFileDialog1, startPath, fileType);

                if (string.IsNullOrWhiteSpace(filePath))
                {

                    AttrMessage.ErrorMsg("请上传图片！");
                }
                else
                {
                    string saveDir = System.Environment.CurrentDirectory + "\\Pic\\";

                    FileHelper.CreateDir(saveDir);

                    string savePath = saveDir + System.IO.Path.GetFileNameWithoutExtension(filePath) + DateTime.Now.ToString("yyyyMMdd") + System.IO.Path.GetExtension(filePath);
                    if (!File.Exists(savePath))
                    {
                        File.Copy(filePath, savePath);
                    }


                    if (File.Exists(savePath))
                    {
                        picbox.ImageLocation = savePath;
                        picPath = savePath;
                    }
                }
            }
            catch (Exception ex)
            {

                AttrMessage.ErrorMsg(ex.Message);
            }
        }

        /// <summary>
        /// 定时器 处理 进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar_ToReadDistinguish.Value < progressBar_ToReadDistinguish.Maximum)
            {
                progressBar_ToReadDistinguish.Value++;

            }
            else
            {
                timer1.Enabled = false;
            }
        }

        /// <summary>
        /// 识别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ToDistinguish_Click(object sender, EventArgs e)
        {
            if (cb_Side.Checked)//反面
            {

                if (string.IsNullOrWhiteSpace(pb_SidePic.ImageLocation))
                {
                    AttrMessage.ErrorMsg("请上传需要识别的反面身份证图片！");
                }
                else
                {
                    Distinguish(pb_SidePic.ImageLocation, "back", false, "true");
                }
            }
            if (cb_Positive.Checked)//正面
            {

                if (string.IsNullOrWhiteSpace(pb_PositivePic.ImageLocation))
                {
                    AttrMessage.ErrorMsg("请上传需要识别的正面身份证图片！");
                }
                else
                {
                    Distinguish(pb_PositivePic.ImageLocation, "front", false, "true");

                }


            }
        }

        /// <summary>
        /// 识别操作
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="id_card_side">身份证 正面还是背面</param>
        /// <param name="detect_direction"></param>
        /// <param name="detect_risk"></param>
        public void Distinguish(string filePath, string id_card_side = "front", bool detect_direction = false, string detect_risk = "false")
        {
            DoTime();//主线程执行进度条，子线程进行数据请求操作
            t1 = new Thread(new ThreadStart(() =>
            {

                var temp = BaiduAIAPI.Access_Token.GetAccessToken();
                if (temp.IsSuccess)
                {
                    string data = "";
                    string error = "";
                    var result = IDCardRecognition.GetIdcardRecognitionString(temp.SuccessModel.access_token, filePath, ref data, out error, id_card_side, detect_direction, detect_risk);
                    this.Invoke(new Action(() =>
                    {
                        tb_showInfo.AppendText("\r\n -----------------------------------------------------------------");
                    }));

                    if (result.state)
                    {
                        this.Invoke(new Action(() =>
                        {
                            tb_showInfo.AppendText("\r\n ---------------------------识别成功-------------------------------");
                            tb_showInfo.AppendText("\r\n" + result.contextModel.successModel.ToJson() + "\r\n");
                        }));

                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {

                            tb_showInfo.AppendText("\r\n-----------------------------识别失败！--------------------------------");
                            tb_showInfo.AppendText("\r\n" + result.contextModel.successModel.ToJson() + result.errorMsg + "\r\n");
                        }));

                    }
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        AttrMessage.ErrorMsg(temp.ErrorModel.error);
                    }));

                }

                this.Invoke(new Action(() =>
                {
                    progressBar_ToReadDistinguish.Value = 100;
                    timer1.Enabled = false;
                    progressBar_ToReadDistinguish.Value = 0;
                }));
            }));

            t1.IsBackground = true;
           t1.Start();

        }

        /// <summary>
        /// 进度条操作
        /// </summary>
        public void DoTime()
        {
            progressBar_ToReadDistinguish.Value = 0;
            progressBar_ToReadDistinguish.Minimum = 0;
            progressBar_ToReadDistinguish.Maximum = 100;
            timer1.Enabled = true;

        }

        private void btn_UploadSidePic_Click(object sender, EventArgs e)
        {
            UploadPic(pb_SidePic);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
