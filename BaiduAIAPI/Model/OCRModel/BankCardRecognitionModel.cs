using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiduAIAPI.Model.ORCModel;

namespace BaiduAIAPI.Model
{
    public class BankCardRecognitionModel
    {
        public bool state { get; set; }

        public BankCardSuccessResultModel successModel { get; set; }

        public ErrorTypeModel errorTypeModel { get; set; }
        /// <summary>
        /// 非接口信息错误
        /// </summary>
        public string errorMsg { get; set; }

        public string returnJson { get; set; }

    }
    public class BankCardSuccessResultModel
    {

        public string log_id { get; set; }
        public BankCardResult result { get; set; }

    }

    public class BankCardResult
    {

        public string bank_card_number { get; set; }
        public string bank_card_type { get; set; }
        public string bank_name { get; set; }

    }
}
