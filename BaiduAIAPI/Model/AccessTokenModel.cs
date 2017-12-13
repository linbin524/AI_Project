using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model
{

    public class AccessTokenModel {

        public bool IsSuccess { get; set; }
        public SuccessAccessTokenModel SuccessModel { get; set; }
        public ErrorAccessTokenModel ErrorModel { get; set; }

    }

    /// <summary>
    /// 获取accesstoken，正常 的 百度接口返回的json 实体模型
    /// </summary>
    public class SuccessAccessTokenModel
    {
        public string refresh_token { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
        public string session_key { get; set; }
        public string session_secret { get; set; }

        public string access_token { get; set; }
    }

    /// <summary>
    /// 获取accesstoken，失败的 百度接口返回的json 实体模型
    /// </summary>
    public class ErrorAccessTokenModel
    {
        public string error { get; set; }
        public string error_description { get; set; }

    }
}
