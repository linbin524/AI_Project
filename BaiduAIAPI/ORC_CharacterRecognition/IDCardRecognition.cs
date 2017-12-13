using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using AOP.Common;
using AOP.Common.DataConversion;
using BaiduAIAPI.Model;
using BaiduAIAPI.Type;

namespace BaiduAIAPI.ORC_Characterbase64
{

    /// <summary>
    /// 文字识别--身份证识别 应用（只是获取身份证图片 信息，没有和公安部联网，无法确认真假，只是单纯从图片上识别文字）
    /// </summary>
    public class IDCardRecognition
    {
        // 身份证识别

        /// <summary>
        /// 身份证识别
        /// </summary>
        /// <param name="token">Accesstoken</param>
        /// <param name="imagePath">图片路径</param>
        /// <param name="recognitionString">识别结果</param>
        /// <param name="errorMsg">错误信息</param>
        /// <param name="id_card_side"> front：身份证正面；back：身份证背面</param>
        /// <param name="detect_direction">是否检测图像朝向，默认不检测，即：false。朝向是指输入图像是正常方向、逆时针旋转90/180/270度。可选值包括:- true：检测朝向；- false：不检测朝向。</param>
        /// <param name="detect_risk"> string 类型 是否开启身份证风险类型(身份证复印件、临时身份证、身份证翻拍、修改过的身份证)功能，默认不开启，即：false。可选值:true-开启；false-不开启</param>
        /// <returns>结果状态</returns>
        public static IDCardRecognitionModel GetIdcardRecognitionString(string token, string imagePath, ref string recognitionString, out string errorMsg, string id_card_side="front", bool detect_direction=false, string detect_risk="false")
        {
            bool resultState = true;
            IDCardRecognitionModel tempModel = new IDCardRecognitionModel();

            try
            {
                #region 基础校验
                string verificationMsg = "";
                errorMsg = "";
                bool isVerification = ImageVerification.VerificationImage(imagePath, out verificationMsg);
                if (!isVerification)
                {

                    errorMsg += verificationMsg;
                    tempModel.state = false;
                    tempModel.errorMsg = errorMsg;
                    return tempModel;
                }
                string strbaser64 = ConvertDataFormatAndImage.ImageToByte64String(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg); // 图片的base64编码
                Encoding encoding = Encoding.Default;
                string urlEncodeImage = HttpUtility.UrlEncode(strbaser64);

                byte[] tempBuffer = encoding.GetBytes(urlEncodeImage);

                if (tempBuffer.Length > 1024 * 1024 * 4)
                {

                    errorMsg += "图片加密 后的大小超过4MB！";
                    recognitionString = "";
                    tempModel.state = false;
                    tempModel.errorMsg = errorMsg;
                    return tempModel;

                }
                #endregion

                #region 请求接口
                recognitionString = "";

                string host = "https://aip.baidubce.com/rest/2.0/ocr/v1/idcard?access_token=" + token;
                String str = "id_card_side=" + id_card_side + "&detect_direction=" + detect_direction + "&detect_risk=" + detect_risk + "&image=" + HttpUtility.UrlEncode(strbaser64);
                var tempResult = HttpRequestHelper.Post(host, str);
                recognitionString = tempResult;

               
                if (recognitionString.Contains("\"error_code\""))//说明异常
                {
                    resultState = false;
                    tempModel.state = false;
                    tempModel.errorTypeModel = Json.ToObject<ErrorTypeModel>(tempResult);
                    tempModel.errorTypeModel.error_discription = ORC_CharacterRecognitionErrorType.GetErrorCodeToDescription(tempModel.errorTypeModel.error_code);
                }
                else
                {
                    tempModel.state = true;
                    tempModel.successModel = Json.ToObject<IDCardRecognitionSuccessResultModel>(tempResult);
                }
                #endregion

                return tempModel;
            }
            catch (Exception ex)//接口外部异常，如网络异常
            {
                resultState = false;
                errorMsg = ex.ToString();
                tempModel.state = false;
                tempModel.errorMsg = ex.ToString();
                return tempModel;
               
            }
        }

    }

}
