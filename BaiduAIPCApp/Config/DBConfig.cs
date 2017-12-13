using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIPCApp.Config
{
    public class DBConfig
    {

        /// <summary>
        /// 默认数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public static string DefaultDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.AppSettings["connectionstring"];
        }
    }
}
