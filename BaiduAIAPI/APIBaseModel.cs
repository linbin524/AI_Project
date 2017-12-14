using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model
{
    public class APIBaseModel<T> where T : class, new()
    {
      
        public T contextModel//这里的context 调用要重新实例化一个
        {
            get;set;
        }
        public bool state { get; set; }

        /// <summary>
        /// 非接口信息错误
        /// </summary>
        public string errorMsg { get; set; }
    }
}
