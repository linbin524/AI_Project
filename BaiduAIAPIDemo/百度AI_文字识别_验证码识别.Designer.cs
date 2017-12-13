namespace BaiduAIAPIDemo
{
    partial class 百度AI_文字识别_验证码识别
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_downloadVerifyCodeImage = new System.Windows.Forms.Button();
            this.pb_verifyCode = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verifyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_downloadVerifyCodeImage
            // 
            this.btn_downloadVerifyCodeImage.Location = new System.Drawing.Point(48, 148);
            this.btn_downloadVerifyCodeImage.Name = "btn_downloadVerifyCodeImage";
            this.btn_downloadVerifyCodeImage.Size = new System.Drawing.Size(100, 23);
            this.btn_downloadVerifyCodeImage.TabIndex = 0;
            this.btn_downloadVerifyCodeImage.Text = "下载远程验证码";
            this.btn_downloadVerifyCodeImage.UseVisualStyleBackColor = true;
            this.btn_downloadVerifyCodeImage.Click += new System.EventHandler(this.btn_downloadVerifyCodeImage_Click);
            // 
            // pb_verifyCode
            // 
            this.pb_verifyCode.Location = new System.Drawing.Point(48, 41);
            this.pb_verifyCode.Name = "pb_verifyCode";
            this.pb_verifyCode.Size = new System.Drawing.Size(100, 69);
            this.pb_verifyCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_verifyCode.TabIndex = 1;
            this.pb_verifyCode.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "识别";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(47, 217);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(566, 163);
            this.tb_Result.TabIndex = 3;
            // 
            // 百度AI_文字识别_验证码识别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 439);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_verifyCode);
            this.Controls.Add(this.btn_downloadVerifyCodeImage);
            this.Name = "百度AI_文字识别_验证码识别";
            this.Text = "百度AI_文字识别_验证码识别";
            ((System.ComponentModel.ISupportInitialize)(this.pb_verifyCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_downloadVerifyCodeImage;
        private System.Windows.Forms.PictureBox pb_verifyCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Result;
    }
}