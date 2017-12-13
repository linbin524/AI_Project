using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Type
{
    /// <summary>
    /// 获取 AccessToken  通过返回的错误码，获取错误描述
    /// </summary>
    public class AccessTokenErrorCodeToDescription
    {
        public static string GetAccessTokenErrorCodeToDescription(string errorCode)
        {
            string errorDecrition = "";
            switch (errorCode)
            {

                case "unknown client id": errorDecrition = "API Key不正确！"; break;
                case "Client authentication failed": errorDecrition = "Secret Key不正确！"; break;
                default: errorDecrition = "未知的错误！"; break;
            }

            return errorDecrition;

        }
    }
}
