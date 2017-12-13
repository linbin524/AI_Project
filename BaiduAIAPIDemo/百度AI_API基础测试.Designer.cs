namespace BaiduAIAPIDemo
{
    partial class 百度AI_API基础测试
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GetAccessToken = new System.Windows.Forms.Button();
            this.tb_AccessToken = new System.Windows.Forms.TextBox();
            this.btn_IDCardRecognition = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_GetAccessToken
            // 
            this.btn_GetAccessToken.Location = new System.Drawing.Point(32, 28);
            this.btn_GetAccessToken.Name = "btn_GetAccessToken";
            this.btn_GetAccessToken.Size = new System.Drawing.Size(130, 23);
            this.btn_GetAccessToken.TabIndex = 0;
            this.btn_GetAccessToken.Text = "获取AccessToken";
            this.btn_GetAccessToken.UseVisualStyleBackColor = true;
            this.btn_GetAccessToken.Click += new System.EventHandler(this.btn_GetAccessToken_Click);
            // 
            // tb_AccessToken
            // 
            this.tb_AccessToken.Location = new System.Drawing.Point(179, 30);
            this.tb_AccessToken.Name = "tb_AccessToken";
            this.tb_AccessToken.Size = new System.Drawing.Size(844, 21);
            this.tb_AccessToken.TabIndex = 1;
            // 
            // btn_IDCardRecognition
            // 
            this.btn_IDCardRecognition.Location = new System.Drawing.Point(32, 114);
            this.btn_IDCardRecognition.Name = "btn_IDCardRecognition";
            this.btn_IDCardRecognition.Size = new System.Drawing.Size(130, 23);
            this.btn_IDCardRecognition.TabIndex = 2;
            this.btn_IDCardRecognition.Text = "上传身份证并识别：";
            this.btn_IDCardRecognition.UseVisualStyleBackColor = true;
            this.btn_IDCardRecognition.Click += new System.EventHandler(this.btn_IDCardRecognition_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(179, 116);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(844, 360);
            this.tb_Result.TabIndex = 3;
            // 
            // 百度AI_API基础测试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 540);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.btn_IDCardRecognition);
            this.Controls.Add(this.tb_AccessToken);
            this.Controls.Add(this.btn_GetAccessToken);
            this.Name = "百度AI_API基础测试";
            this.Text = "百度AI API基础测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetAccessToken;
        private System.Windows.Forms.TextBox tb_AccessToken;
        private System.Windows.Forms.Button btn_IDCardRecognition;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_Result;
    }
}

