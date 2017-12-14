using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model
{

    /// <summary>
    /// 身份证识别 实体
    /// </summary>
    public class IDCardRecognitionModel
    {
     

        public IDCardRecognitionSuccessResultModel successModel { get; set; }

        public ErrorTypeModel errorTypeModel { get; set; }
     
    }

    public class IDCardRecognitionSuccessResultModel
    {

        public long log_id { get; set; }

        public int direction { get; set; }

        public int words_result_num { get; set; }

        public string image_status { get; set; }
        public string idcard_type { get; set; }
        public string edit_tool { get; set; }

        public string risk_type { get; set; }
        public Words_result words_result { get; set; }
    }

    public class Words_result
    {


        public 住址 住址 { get; set; }
        public 公民身份号码 公民身份号码 { get; set; }
        public 出生 出生 { get; set; }
        public 姓名 姓名 { get; set; }
        public 性别 性别 { get; set; }

        public 民族 民族 { get; set; }

        public 签发日期 签发日期 { get; set; }
        public 失效日期 失效日期 { get; set; }
        public 签发机关 签发机关 { get; set; }

    }

    public class 住址
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 公民身份号码
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 出生
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 姓名
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 性别
    {

        public Location location { get; set; }
        public string words { get; set; }
    }
    public class 民族
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 签发日期
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 失效日期
    {

        public Location location { get; set; }
        public string words { get; set; }
    }

    public class 签发机关
{

        public Location location { get; set; }
        public string words { get; set; }
    }



    public class Location
    {

        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }

    }

    public class DicModel
    {

        public string words { get; set; }
        public Location location { get; set; }

    }



}
