using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using AOP.Common;
using Baidu.Aip.Ocr;
using BaiduAIAPI;
using BaiduAIAPI.Model;
using BaiduAIAPI.Model.ORCModel;
using BaiduAIAPI.Type;

namespace Baidu.Aip.API
{
    public class OcrAPI
    {

        public static void GeneralBasic()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 通用文字识别
            var result = client.GeneralBasic(image);

            // 图片url
            result = client.GeneralBasic("https://www.baidu.com/img/bd_logo1.png");
        }

        public static string GeneralBasic(Image tempImage)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);

            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            // 通用文字识别
            var result = client.GeneralBasic(image);
            return result.ToJson();

        }

        public static void GeneralEnhanced()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 带生僻字版
            var result = client.GeneralEnhanced(image);
        }

        public static string GeneralEnhanced(Image tempImage)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            // 带生僻字版
            var result = client.GeneralEnhanced(image);
            return result.ToJson();
        }

        public static void GeneralWithLocatin()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 带位置版本
            var result = client.GeneralWithLocatin(image, null);
        }

        #region 网络图片识别，适合网络图片文字识别用于识别一些网络上背景复杂，特殊字体的文字。
        public static void WebImage()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 网图识别
            var result = client.WebImage(image, null);
        }

        /// <summary>
        /// 网络图片识别，适合网络图片文字识别用于识别一些网络上背景复杂，特殊字体的文字。
        /// </summary>
        /// <param name="tempImage"></param>
        /// <returns>返回 json 字符串</returns>
        public static string WebImage(Image tempImage)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            string result = client.WebImage(image, null).ToString();
            return result;
        }

        /// <summary>
        /// 网络图片识别，适合网络图片文字识别用于识别一些网络上背景复杂，特殊字体的文字。
        /// </summary>
        /// <param name="tempImage"></param>
        public static APIBaseModel<DrivingLicenseModel> GetWebImage(Image tempImage)
        {

            APIBaseModel<DrivingLicenseModel> tempModel = new APIBaseModel<DrivingLicenseModel>();
            tempModel.contextModel = new DrivingLicenseModel();

            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            string result = client.WebImage(image, null).ToString();
            if (result.Contains("\"error_code\""))//说明异常
            {

                tempModel.state = false;
                tempModel.contextModel.errorTypeModel = Json.ToObject<ErrorTypeModel>(result);
                tempModel.errorMsg = tempModel.contextModel.errorTypeModel.error_discription = OCR_CharacterRecognitionErrorType.GetErrorCodeToDescription(tempModel.contextModel.errorTypeModel.error_code);

            }
            else
            {
                tempModel.state = true;
                tempModel.contextModel.successModel = Json.ToObject<DrivingLicenseSuessResultModel>(result);

            }
            return tempModel;
        } 
        #endregion


        public static void Accurate()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 高精度识别
            var result = client.Accurate(image);
        }


        public static string Accurate(Image tempImage)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            // 高精度识别
            var result = client.Accurate(image);
            return result.ToJson();
        }

        public static void AccurateWithLocation()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            // 高精度识别(带位置信息)
            var result = client.AccurateWithLocation(image);
        }


        public static void BankCard(string imagePath)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes(imagePath);

            // 银行卡识别
            var result = client.BankCard(image);
        }

        public static void Idcard()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");

            var options = new Dictionary<string, object>
            {
                {"detect_direction", "true"} // 检测方向
            };
            // 身份证正面识别
            var result = client.IdCardFront(image, options);
            // 身份证背面识别
            result = client.IdCardBack(image);
        }

        #region 

        public static void DrivingLicense()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var result = client.DrivingLicense(image);
        }

        /// <summary>
        /// 基础
        /// </summary>
        /// <param name="tempImage"></param>
        /// <returns></returns>
        public static string DrivingLicense(Image tempImage)
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            var result = client.DrivingLicense(image);
            return result.ToString();
        }


        #endregion

        public static void VehicleLicense()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var result = client.VehicleLicense(image);
        }

        public static void PlateLicense()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var result = client.PlateLicense(image);
        }


        /// <summary>
        /// 车牌识别 返回实体结果
        /// </summary>
        /// <param name="tempImage"></param>
        /// <returns></returns>
        public static APIBaseModel<DrivingLicenseModel> GetPlateLicense(Image tempImage)
        {

            APIBaseModel<DrivingLicenseModel> tempModel = new APIBaseModel<DrivingLicenseModel>();
            tempModel.contextModel = new DrivingLicenseModel();

            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            string result = client.PlateLicense(image).ToString();
            if (result.Contains("\"error_code\""))//说明异常
            {

                tempModel.state = false;
                tempModel.contextModel.errorTypeModel = Json.ToObject<ErrorTypeModel>(result);
                tempModel.errorMsg = tempModel.contextModel.errorTypeModel.error_discription = OCR_CharacterRecognitionErrorType.GetErrorCodeToDescription(tempModel.contextModel.errorTypeModel.error_code);

            }
            else
            {
                tempModel.state = true;
                tempModel.contextModel.successModel = Json.ToObject<DrivingLicenseSuessResultModel>(result);

            }
            return tempModel;
        }

        public static void Receipt()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var options = new Dictionary<string, object>
            {
                {"recognize_granularity", "small"} // 定位单字符位置
            };
            var result = client.Receipt(image, options);
        }


        public static void BusinessLicense()
        {
            var client = new Ocr.Ocr(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var result = client.BusinessLicense(image);
        }

        public static void FormBegin()
        {
            var form = new Form(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            form.DebugLog = false; // 是否开启调试日志

            var result = form.BeginRecognition(image);
            Console.Write(result);
        }

        public static void FormGetResult()
        {
            var form = new Form(Config.clientId, Config.clientSecret);
            var options = new Dictionary<string, object>
            {
                {"result_type", "json"} // 或者为excel
            };
            var result = form.GetRecognitionResult("123344", options);
            Console.Write(result);
        }

        public static void FormToJson()
        {
            var form = new Form(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            form.DebugLog = false; // 是否开启调试日志

            // 识别为Json
            var result = form.RecognizeToJson(image);
            Console.Write(result);
        }

        public static void FormToExcel()
        {
            var form = new Form(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            form.DebugLog = false; // 是否开启调试日志

            // 识别为Excel
            var result = form.RecognizeToExcel(image);
            Console.Write(result);
        }
    }
}