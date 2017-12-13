
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoSurveilance;

namespace AOP.Common
{
    /// <summary>
    /// 1 制造了一个 图片截取的（内存）队列。当出现异常之后，
    /// 直接把图片保存操作放到内存的队列里去。
    /// 然后Web继续往下执行，给用户反馈信息。不会阻塞用户的响应。
    /// 
    /// </summary>
    public class HttpToBaiduQueueHelper
    {
        //异常信息的队列
        public static Queue<ImageModel> ExcRect;

        static HttpToBaiduQueueHelper()
        {
            ExcRect = new Queue<ImageModel>();
            ThreadPool.QueueUserWorkItem(u =>
                {
                    while (true)
                    {
                        ImageModel imageTemp = new ImageModel();
                       
                        if (ExcRect==null)
                        {
                            continue;
                        }

                        lock (ExcRect)
                        {
                            if (ExcRect.Count > 0)
                                imageTemp = ExcRect.Dequeue();
                          
                        }
                        //执行队列操作
                        if (imageTemp.Rect != null&&imageTemp.Image!=null)
                        {
                            string saveDir = System.Environment.CurrentDirectory + "\\SaveImages\\";
                            FileHelper.CreateDir(saveDir);
                            string saveFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                            //1、保存识别到的脸部截图
                            string savePath = saveDir + saveFileName;
                            ImageHelper.CaptureImage(imageTemp.Image, imageTemp.Rect, savePath);
                        }
                        if (ExcRect.Count() <= 0)
                        {
                            Thread.Sleep(30);
                        }


                    }
                });
        }

        public static void WriteImage(ImageModel msg)
        {
            lock (ExcRect)
            {
                ExcRect.Enqueue(msg);
            }

        }

     


    }


}
