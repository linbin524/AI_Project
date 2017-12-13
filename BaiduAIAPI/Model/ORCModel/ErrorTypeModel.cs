using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model
{
    /// <summary>
    /// 错误信息 实体
    /// </summary>
    public class ErrorTypeModel
    {
        /// <summary>
        /// 日志Id
        /// </summary>
        public string log_id { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        public string error_code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string error_msg { get; set; }

        /// <summary>
        /// 错误信息中文描述
        /// </summary>
        public string error_discription { get; set; }
    }
}
