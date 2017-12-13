using System.Collections.Generic;
using System.Drawing;
using System.IO;
using AOP.Common;
using BaiduAIAPI;
using BaiduAIAPI.Model;

namespace Baidu.Aip.API
{
    public class FaceAPI
    {
        public static void FaceMatch()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes("图片文件路径");
            var image2 = File.ReadAllBytes("图片文件路径");
            var image3 = File.ReadAllBytes("图片文件路径");

            var images = new[] { image1, image2, image3 };

            // 人脸对比
            var result = client.FaceMatch(images);
        }

        /// <summary>
        /// 人脸检测
        /// </summary>
        public static void FaceDetect()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image = File.ReadAllBytes("图片文件路径");
            var options = new Dictionary<string, object>
            {
                {"face_fields", "age,beauty,expression,faceshape,gender,glasses,landmark,race,qualities"}
            };
            var result = client.FaceDetect(image, options);
        }

        /// <summary>
        /// 人脸检测
        /// </summary>
        public static string FaceDetect(Image tempImage)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            string tempProperty = "age,beauty,expression,faceshape,gender,glasses,landmark,race,qualities";
            var image = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);
            var options = new Dictionary<string, object>
            {
                {"face_fields", "age,beauty,expression,glasses,race"}
            };
            var result = client.FaceDetect(image, options);
            return result.ToString();
        }

        public static void FaceRegister()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes("图片文件路径");

            var result = client.User.Register(image1, "uid", "user info here", new[] { "groupId" });
        }

        /// <summary>
        /// 人脸注册
        /// </summary>
        /// <param name="imagePath">图片地址</param>
        /// <param name="uid">人员Uid</param>
        /// <param name="userInfo">人员信息</param>
        /// <param name="groupId">组别编号</param>
        /// <returns></returns>
        public static string FaceRegister(string imagePath,string uid,string userInfo,string groupId)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes(imagePath);

            var result = client.User.Register(image1, uid, userInfo, new[] { groupId });
            return result.ToString();
        }

        public static void FaceUpdate()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes("图片文件路径");

            var result = client.User.Update(image1, "uid", "groupId", "new user info");
        }

         /// <summary>
         /// 人脸更新
         /// </summary>
         /// <param name="imagePath"></param>
         /// <param name="uid"></param>
         /// <param name="userInfo"></param>
         /// <param name="groupId"></param>
         /// <returns></returns>
        public static string FaceUpdate(string imagePath, string uid, string userInfo, string groupId)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes(imagePath);

            var result = client.User.Update(image1, uid, groupId, userInfo);

            return result.ToString();
        }

        public static void FaceDelete()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.User.Delete("uid");
            result = client.User.Delete("uid", new[] { "group1" });
        }

        /// <summary>
        /// 人脸删除
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public static string FaceDelete(string uid,string groupId)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.User.Delete(uid);
            result = client.User.Delete(uid, new[] { groupId });
            return result.ToString();
        }

        public static void FaceVerify()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes("图片文件路径");

            var result = client.User.Verify(image1, "uid", new[] { "groupId" }, 1);
        }

        public static void FaceIdentify()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = File.ReadAllBytes("图片文件路径");

            var result = client.User.Identify(image1, new[] { "groupId" }, 10, 10);
        }

        /// <summary>
        /// 人脸识别 人脸库比对
        /// </summary>
        /// <param name="tempImage"></param>
        /// <param name="groupId"></param>
        public static FaceIdentifyModel FaceIdentify(Image tempImage,string groupId,int userTopNum=1,int faceTopNum=1)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var image1 = ImageHelper.ImageToBytes(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            var result = client.User.Identify(image1, new[] { groupId }, userTopNum, faceTopNum);
            return result.ToObject<FaceIdentifyModel>();
        }

        public static void UserInfo()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.User.GetInfo("uid");
        }

        /// <summary>
        /// 返回指定的用户信息
        /// </summary>
        /// <param name="uid"></param>
        public static string UserInfo(string uid)
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.User.GetInfo(uid);
            return result.ToString();
        }

        public static void GroupList()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.Group.GetAllGroups(0, 100);
        }

        public static void GroupUsers()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.Group.GetUsers("groupId", 0, 100);
        }

        public static void GroupAddUser()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.Group.AddUser(new[] { "toGroupId" }, "uid", "fromGroupId");
        }

        public static void GroupDeleteUser()
        {
            var client = new Face.Face(Config.clientId, Config.clientSecret);
            var result = client.Group.DeleteUser(new[] { "groupId" }, "uid");
        }
    }
}