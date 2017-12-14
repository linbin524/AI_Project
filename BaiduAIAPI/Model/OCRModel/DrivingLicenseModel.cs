using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model.ORCModel
{

    /// <summary>
    /// 车牌识别实体模型
    /// </summary>
    public class DrivingLicenseModel
    {

        public DrivingLicenseSuessResultModel successModel { get; set; }

        public ErrorTypeModel errorTypeModel { get; set; }
    }

    public class DrivingLicenseSuessResultModel
    {

        public long log_id { get; set; }

        public Words_result words_result { get; set; }
    }


    public class Words_result
    {
        public string color { get; set; }
        public string number { get; set; }

    }
}
