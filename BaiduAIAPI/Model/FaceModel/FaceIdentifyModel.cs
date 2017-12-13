using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduAIAPI.Model
{
    public class FaceIdentifyModel
    {
        public string log_id { get; set; }
        public string result_num { get; set; }

        public List<FaceIdentifyUserInfo> result { get; set; }

        public Rectangle rect { get; set; }
    }

    public class FaceIdentifyUserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public string uid { get; set; }

        /// <summary>
        /// 组信息
        /// </summary>
        public string group_id { get; set; }

        /// <summary>
        /// 人脸匹配得分 0~100
        /// </summary>
        public double[] scores { get; set; }
        public string user_info { get; set; }


    }
}
