using AOP.Common;
using AOP.Common.WinForm;
using AOP.Core.DBData;
using AOP.Data;
using AOP.Model;
using AOP.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiduAIPCApp
{
    static class Program
    {
      
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

           
          
           

                //设置应用程序处理异常方式：ThreadException处理
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new Form_Bast());

           
          


        }


        #region 异常处理

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.Exception, e.ToString());
            //log4net.ILog log = log4net.LogManager.GetLogger(e.Exception.GetType());
            //log.Debug(" Application_ThreadException Enter initMenus()");
            //log.Error(str.ToString());
            LogInfo logInfo = new LogInfo();
            logInfo.IsEnable = true;
            logInfo.LogContent = str;
            logInfo.LogName = "应用程序主线程捕获异常";
            logInfo.LogTime = DateTime.Now;
            logInfo.LogType = ((LogType)2).ToString();
            //db.Add<LogInfo>(logInfo);

        }

        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
            //log4net.ILog log = log4net.LogManager.GetLogger((e.ExceptionObject as Exception).GetType());
            //log.Debug("CurrentDomain_UnhandledException Enter initMenus()");
            //log.Error(str.ToString());
            LogInfo logInfo = new LogInfo();
            logInfo.IsEnable = true;
            logInfo.LogContent = str;
            logInfo.LogName = "非UI线程异常";
            logInfo.LogTime = DateTime.Now;
            logInfo.LogType = ((LogType)3).ToString();
            //db.Add<LogInfo>(logInfo);

        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        public static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            if (ex != null)
            {
                sb.AppendLine("【异常源】：" + ex.InnerException);
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);

                sb.AppendLine("【异常方法】：" + ex.TargetSite);

            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }
        #endregion
    }
}
