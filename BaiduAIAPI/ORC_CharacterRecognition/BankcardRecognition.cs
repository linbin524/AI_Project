using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AOP.Common;
using AOP.Common.DataConversion;
using BaiduAIAPI.Model;
using BaiduAIAPI.Type;

namespace BaiduAIAPI.ORC_CharacterRecognition
{
    public class BankCardRecognition
    {
        public static BankCardRecognitionModel GetBankCardRecognitionString(string token, string imagePath, ref string recognitionString, out string errorMsg)
        {
            bool resultState = true;
            BankCardRecognitionModel tempModel = new BankCardRecognitionModel();
            errorMsg = "";
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
                //注意，转换时候 一直传递是 接口适配的文件类型，所有图片的类型转换很关键
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

                string host = "https://aip.baidubce.com/rest/2.0/ocr/v1/bankcard?access_token=" + token;
                String str = "&image=" + HttpUtility.UrlEncode(strbaser64);
                var tempResult = HttpRequestHelper.Post(host, str);
                recognitionString = tempResult;
                tempModel.returnJson = tempResult;

                if (recognitionString.Contains("\"error_code\""))//说明异常
                {
                    resultState = false;
                    tempModel.state = false;
                    tempModel.errorTypeModel = Json.ToObject<Model.ErrorTypeModel>(tempResult);
                    tempModel.errorTypeModel.error_discription = ORC_CharacterRecognitionErrorType.GetErrorCodeToDescription(tempModel.errorTypeModel.error_code);
                }
                else
                {
                    tempModel.state = true;
                    tempModel.successModel = Json.ToObject<BankCardSuccessResultModel>(tempResult);
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
