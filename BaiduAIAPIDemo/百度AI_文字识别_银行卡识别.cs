using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiduAIAPI;
using BaiduAIAPI.Model;
using BaiduAIAPI.ORC_CharacterRecognition;

namespace BaiduAIAPIDemo
{
    public partial class Form_BankCardRecognition : Form
    {
        string imagePath = System.Environment.CurrentDirectory + "\\Pic\\BankCard\\jh.png";
        public Form_BankCardRecognition()
        {
            InitializeComponent();

            pb_BankCard.ImageLocation = imagePath;
        }

        private void BankCardRecognition_Click(object sender, EventArgs e)
        {

            // OcrDemo.BankCard(imagePath);
            string getRecognitonString = "";
            string errorString = "";
            var tempTokenModel = Access_Token.GetAccessToken();
            if (tempTokenModel.IsSuccess)
            {

                BankCardRecognitionModel tempModel= BankCardRecognition.GetBankCardRecognitionString(tempTokenModel.SuccessModel.access_token, imagePath, ref getRecognitonString, out errorString);

                tb_Json.Text = getRecognitonString;
            }

        }
    }
}
