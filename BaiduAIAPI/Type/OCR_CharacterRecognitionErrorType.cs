using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiduAIAPI.Model;

namespace BaiduAIAPI.Type
{
    /// <summary>
    /// 文字识别 错误码信息
    /// </summary>
    public class OCR_CharacterRecognitionErrorType
    {
        public static string GetErrorCodeToDescription(string errorCode)
        {
            string errorDecrition = "";

            switch (errorCode)
            {

                case "1": errorDecrition = "服务器内部错误，请再次请求， 如果持续出现此类错误，请通过QQ群（224994340）或工单联系技术支持团队。"; break;
                case "2": errorDecrition = "服务暂不可用，请再次请求， 如果持续出现此类错误，请通过QQ群（224994340）或工单联系技术支持团队。"; break;

                case "3": errorDecrition = "调用的API不存在，请检查后重新尝试。"; break;
                case "4": errorDecrition = "集群超限额。"; break;
                case "6": errorDecrition = "无权限访问该用户数据。"; break;
                case "14": errorDecrition = "IAM鉴权失败，建议用户参照文档自查生成sign的方式是否正确，或换用控制台中ak sk的方式调用。"; break;
                case "17": errorDecrition = "每天请求量超限额。"; break;
                case "18": errorDecrition = "QPS超限额。"; break;
                case "19": errorDecrition = "请求总量超限额。"; break;

                case "100": errorDecrition = "无效的access_token参数，请检查后重新尝试。"; break;
                case "110": errorDecrition = "access token过期。"; break;
                case "282000": errorDecrition = "服务器内部错误，如果您使用的是高精度接口，报这个错误码的原因可能是您上传的图片中文字过多，识别超时导致的，建议您对图片进行切割后再识别，其他情况请再次请求， 如果持续出现此类错误，请通过QQ群（631977213）或工单联系技术支持团队。"; break;
                case "216100": errorDecrition = "请求中包含非法参数，请检查后重新尝试。"; break;
                case "216101": errorDecrition = "缺少必须的参数，请检查参数是否有遗漏。"; break;
                case "216102": errorDecrition = "请求了不支持的服务，请检查调用的url。"; break;
                case "216103": errorDecrition = "请求中某些参数过长，请检查后重新尝试。"; break;
                case "216110": errorDecrition = "appid不存在，请重新核对信息是否为后台应用列表中的appid。"; break;
                case "216200": errorDecrition = "图片为空，请检查后重新尝试。"; break;
                case "216201": errorDecrition = "上传的图片格式错误，现阶段我们支持的图片格式为：PNG、JPG、JPEG、BMP，请进行转码或更换图片。"; break;
                case "216202": errorDecrition = "上传的图片大小错误，现阶段我们支持的图片大小为：base64编码后小于4M，分辨率不高于4096*4096，请重新上传图片。"; break;
                case "216630": errorDecrition = "识别错误，请再次请求，如果持续出现此类错误，请通过QQ群（631977213）或工单联系技术支持团队。"; break;
                case "216631": errorDecrition = "识别银行卡错误，出现此问题的原因一般为：您上传的图片非银行卡正面，上传了异形卡的图片或上传的银行卡正品图片不完整。"; break;
                case "216633": errorDecrition = "识别身份证错误，出现此问题的原因一般为：您上传了非身份证图片或您上传的身份证图片不完整。"; break;

                case "216634": errorDecrition = "检测错误，请再次请求，如果持续出现此类错误，请通过QQ群（631977213）或工单联系技术支持团队。"; break;
                case "282003": errorDecrition = "请求参数缺失。"; break;
                case "282005": errorDecrition = "处理批量任务时发生部分或全部错误，请根据具体错误码排查。"; break;
                case "282006": errorDecrition = "批量任务处理数量超出限制，请将任务数量减少到10或10以下。"; break;
                case "282110": errorDecrition = "URL参数不存在，请核对URL后再次提交。"; break;
                case "282111": errorDecrition = "URL格式非法，请检查url格式是否符合相应接口的入参要求。"; break;
                case "282112": errorDecrition = "url下载超时，请检查url对应的图床/图片无法下载或链路状况不好，您可以重新尝试一下，如果多次尝试后仍不行，建议更换图片地址。"; break;
                case "282113": errorDecrition = "URL返回无效参数。"; break;
                case "282114": errorDecrition = "URL长度超过1024字节或为0。"; break;
                case "282808": errorDecrition = "request id xxxxx 不存在。"; break;
                case "282809": errorDecrition = "返回结果请求错误（不属于excel或json）。"; break;
                case "282810": errorDecrition = "图像识别错误。"; break;

                default: errorDecrition = "未知的错误！"; break;
            }

            return errorDecrition;

        }
    }


}
