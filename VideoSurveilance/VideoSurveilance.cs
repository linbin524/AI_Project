//----------------------------------------------------------------------------
//  Copyright (C) 2004-2017 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;
using FaceDetection;
using Emgu.CV.Cuda;
using AOP.Common;
using System.Drawing.Imaging;
using Baidu.Aip.API;
using System.Threading;
using BaiduAIAPI.Model;

namespace VideoSurveilance
{
    public partial class VideoSurveilance : Form
    {
       
        private static VideoCapture _cameraCapture;

        private static BackgroundSubtractor _fgDetector;
        private static Emgu.CV.Cvb.CvBlobDetector _blobDetector;
        private static Emgu.CV.Cvb.CvTracks _tracker;

        private static Queue<ImageModel> FacIdentifyQueue = new Queue<ImageModel>();
        public Image faceImage;
        Thread t1;
        public VideoSurveilance()
        {
            InitializeComponent();
            Run();
        }

        void Run()
        {
            try
            {
                _cameraCapture = new VideoCapture();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            _fgDetector = new Emgu.CV.VideoSurveillance.BackgroundSubtractorMOG2();
            _blobDetector = new CvBlobDetector();
            _tracker = new CvTracks();

            Application.Idle += ProcessFrame;
        }

        void ProcessFrame(object sender, EventArgs e)
        {
            Mat frame = _cameraCapture.QueryFrame();
            Mat smoothedFrame = new Mat();
            CvInvoke.GaussianBlur(frame, smoothedFrame, new Size(3, 3), 1); //filter out noises
                                                                            //frame._SmoothGaussian(3); 
           
            #region use the BG/FG detector to find the forground mask

            Mat forgroundMask = new Mat();
            _fgDetector.Apply(smoothedFrame, forgroundMask);
            #endregion

            CvBlobs blobs = new CvBlobs();
            _blobDetector.Detect(forgroundMask.ToImage<Gray, byte>(), blobs);
            blobs.FilterByArea(100, int.MaxValue);

            float scale = (frame.Width + frame.Width) / 2.0f;
            _tracker.Update(blobs, 0.01 * scale, 5, 5);

            long detectionTime;

            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            IImage image = (IImage)frame;//这一步是重点
            faceImage = frame.Bitmap;
            DetectFace.Detect(image
             , "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
              faces, eyes,
              out detectionTime);

            #region 多人识别 多人识别存在较大误差率（图片库 如果高清，识别效果就是好）
            //Graphics g1 = Graphics.FromImage(frame.Bitmap);
            //List<FaceIdentifyModel> tempList = new List<FaceIdentifyModel>();
            //foreach (Rectangle face in faces)
            //{
            //    Image rectImage1 = ImageHelper.CaptureImage(frame.Bitmap, face);
            //    FaceIdentifyModel MoreIdentifyInfo = FaceAPI.FaceIdentify(rectImage1, tb_Group.Text.Trim(), 1, 1);//人脸识别 一个人的识别效果比较好 
            //    MoreIdentifyInfo.rect = face;
            //    tempList.Add(MoreIdentifyInfo);
            //}
            //Color color_of_pen1 = Color.Gray;
            //color_of_pen1 = Color.Yellow;
            //Pen pen1 = new Pen(color_of_pen1, 2.0f);

            //Font font1 = new Font("微软雅黑", 16, GraphicsUnit.Pixel);
            //SolidBrush drawBrush1 = new SolidBrush(Color.Yellow);


            //tb_Identify.Text = tempList.ToJson();
            //foreach (var t in tempList)
            //{
            //    g1.DrawRectangle(pen1, t.rect);

            //    if (t.result != null)
            //    {
            //        g1.DrawString(t.result[0].user_info.Replace("，", "\r\n"), font1, drawBrush1, new Point(t.rect.X + 20, t.rect.Y - 20));
            //    }

            //}
            #endregion

            #region 单人识别
            //单人 人脸识别 多人效果比较差
            foreach (Rectangle face in faces)
            {
                
                #region 采用画图，显示自己的文本框
                Graphics g = Graphics.FromImage(frame.Bitmap);

                ImageModel tempImage = new ImageModel();
                tempImage.Rect = face;
                tempImage.Image = frame.Bitmap;

                //接口查询速度差
                //string faceInfo = FaceAPI.FaceDetect(ImageHelper.CaptureImage(frame.Bitmap, face));//人脸检测

                Image rectImage = ImageHelper.CaptureImage(frame.Bitmap, face);
                FaceIdentifyModel IdentifyInfo = FaceAPI.FaceIdentify(rectImage, tb_Group.Text.Trim(), 1, 1);//人脸识别 一个人的识别效果比较好                                                                                          // tb_Result.Text = faceInfo;
                tb_Identify.Text = IdentifyInfo.ToJson().ToString();
                //采用画板
                Color color_of_pen = Color.Gray;
                color_of_pen = Color.Yellow;
                Pen pen = new Pen(color_of_pen, 2.0f);
                Rectangle rect = face;

                g.DrawRectangle(pen, rect);
                Font font = new Font("微软雅黑", 16, GraphicsUnit.Pixel);
                SolidBrush drawBrush = new SolidBrush(Color.Yellow);


                if (IdentifyInfo != null)
                {
                    if (IdentifyInfo.result != null)
                    {
                        for (int i = 0; i < IdentifyInfo.result.Count; i++)
                        {
                            string faceInfo = "";
                            faceInfo = IdentifyInfo.result[i].user_info.Replace("，", "\r\n");
                            //显示用户信息
                            g.DrawString(faceInfo, font, drawBrush, new Point(face.X + 20, face.Y - 20));
                        }
                    }

                }

                //CvInvoke.Rectangle(frame, face, new MCvScalar(255.0, 255.0, 255.0), 2);
                //CvInvoke.PutText(frame, faceInfo, new Point(face.X + 20, face.Y - 20), FontFace.HersheyPlain, 1.0, new MCvScalar(255.0, 255.0, 255.0));

                // 保存原始截图
                //System.Drawing.Image ResourceImage = frame.Bitmap;
                //ResourceImage.Save(saveDir + saveFileName);



                //线程队列 保存人脸识别截图
                QueueHelper.WriteImage(tempImage);



                //t1 = new Thread(new ThreadStart(() =>
                //{
                //    faceInfo = FaceAPI.FaceDetect(ImageHelper.CaptureImage(frame.Bitmap, face));
                //    this.Invoke(new Action(() =>
                //    {

                //        g.DrawString(faceInfo, font, drawBrush, new Point(face.X + 20, face.Y - 20));
                //    }));

                //}));

                //t1.IsBackground = true;
                //t1.Start();


                #endregion
            }
            #endregion

            #region 视频调用原有的Open CV 不支持中文字

            //foreach (var pair in _tracker)
            //{
            //    CvTrack b = pair.Value;

            //    #region 视频中调用open CV 上直接画文本框
            //    CvInvoke.Rectangle(frame, b.BoundingBox, new MCvScalar(255.0, 255.0, 255.0), 2);
            //    CvInvoke.PutText(frame, "man,show", new Point((int)Math.Round(b.Centroid.X), (int)Math.Round(b.Centroid.Y)), FontFace.HersheyPlain, 1.0, new MCvScalar(255.0, 255.0, 255.0));
            //    if (b.BoundingBox.Width < 100 || b.BoundingBox.Height < 50)
            //    {

            //        continue;
            //    }
            //    #endregion

            //}
            #endregion

            imageBox1.Image = frame;
            imageBox2.Image = forgroundMask;
        }

        #region 从大图中截取一部分图片
        /// <summary>
        /// 从大图中截取一部分图片
        /// </summary>
        /// <param name="fromImagePath">来源图片地址</param>        
        /// <param name="offsetX">从偏移X坐标位置开始截取</param>
        /// <param name="offsetY">从偏移Y坐标位置开始截取</param>
        /// <param name="toImagePath">保存图片地址</param>
        /// <param name="width">保存图片的宽度</param>
        /// <param name="height">保存图片的高度</param>
        /// <returns></returns>
        public void CaptureImage(string fromImagePath, int offsetX, int offsetY, string toImagePath, int width, int height)
        {
            //原图片文件
            Image fromImage = Image.FromFile(fromImagePath);
            //创建新图位图
            Bitmap bitmap = new Bitmap(width, height);
            //创建作图区域
            Graphics graphic = Graphics.FromImage(bitmap);
            //截取原图相应区域写入作图区
            graphic.DrawImage(fromImage, 0, 0, new Rectangle(offsetX, offsetY, width, height), GraphicsUnit.Pixel);
            //从作图区生成新图
            Image saveImage = Image.FromHbitmap(bitmap.GetHbitmap());
            //保存图片
            saveImage.Save(toImagePath, ImageFormat.Png);
            //释放资源   
            saveImage.Dispose();
            graphic.Dispose();
            bitmap.Dispose();
        }

        public void CaptureImage(Image fromImage, Rectangle rect, string toImagePath)
        {

            //创建新图位图
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height);
            //创建作图区域
            Graphics graphic = Graphics.FromImage(bitmap);
            //截取原图相应区域写入作图区
            graphic.DrawImage(fromImage, 0, 0, rect, GraphicsUnit.Pixel);
            //从作图区生成新图
            Image saveImage = Image.FromHbitmap(bitmap.GetHbitmap());
            //保存图片
            saveImage.Save(toImagePath, ImageFormat.Png);
            //释放资源   
            saveImage.Dispose();
            graphic.Dispose();
            bitmap.Dispose();
        }
        #endregion

        private void btn_Screenshot_Click(object sender, EventArgs e)
        {
            if (faceImage != null)
            {
                System.Drawing.Image ResourceImage = faceImage;
                string fileDir = System.Environment.CurrentDirectory + "\\Snapshot\\";
                FileHelper.CreateDir(fileDir);
                string filePath = fileDir + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                ResourceImage.Save(filePath);
                MessageBox.Show("保存成功！" + filePath);
            }

        }
    }
}