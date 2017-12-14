namespace BaiduAIAPIDemo
{
    partial class 百度AI_文字识别_车牌识别
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.pic_CarId = new System.Windows.Forms.PictureBox();
            this.btn_UploadPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CarId)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(562, 82);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(124, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "车牌开始识别";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(562, 201);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(517, 248);
            this.tb_result.TabIndex = 1;
            // 
            // pic_CarId
            // 
            this.pic_CarId.Location = new System.Drawing.Point(23, 82);
            this.pic_CarId.Name = "pic_CarId";
            this.pic_CarId.Size = new System.Drawing.Size(398, 311);
            this.pic_CarId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_CarId.TabIndex = 2;
            this.pic_CarId.TabStop = false;
            // 
            // btn_UploadPic
            // 
            this.btn_UploadPic.Location = new System.Drawing.Point(439, 82);
            this.btn_UploadPic.Name = "btn_UploadPic";
            this.btn_UploadPic.Size = new System.Drawing.Size(75, 23);
            this.btn_UploadPic.TabIndex = 3;
            this.btn_UploadPic.Text = "上传图片";
            this.btn_UploadPic.UseVisualStyleBackColor = true;
            this.btn_UploadPic.Click += new System.EventHandler(this.btn_UploadPic_Click);
            // 
            // 百度AI_文字识别_车牌识别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 491);
            this.Controls.Add(this.btn_UploadPic);
            this.Controls.Add(this.pic_CarId);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_Start);
            this.Name = "百度AI_文字识别_车牌识别";
            this.Text = "百度AI_文字识别_车牌识别";
            ((System.ComponentModel.ISupportInitialize)(this.pic_CarId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.PictureBox pic_CarId;
        private System.Windows.Forms.Button btn_UploadPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}