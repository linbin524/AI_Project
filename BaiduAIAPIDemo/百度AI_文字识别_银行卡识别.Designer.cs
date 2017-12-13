namespace BaiduAIAPIDemo
{
    partial class Form_BankCardRecognition
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
            this.pb_BankCard = new System.Windows.Forms.PictureBox();
            this.btn_BankCardRecognition = new System.Windows.Forms.Button();
            this.tb_Json = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BankCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_BankCard
            // 
            this.pb_BankCard.Location = new System.Drawing.Point(33, 56);
            this.pb_BankCard.Name = "pb_BankCard";
            this.pb_BankCard.Size = new System.Drawing.Size(453, 297);
            this.pb_BankCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_BankCard.TabIndex = 0;
            this.pb_BankCard.TabStop = false;
            // 
            // Form_BankCardRecognition
            // 
            this.btn_BankCardRecognition.Location = new System.Drawing.Point(552, 56);
            this.btn_BankCardRecognition.Name = "Form_BankCardRecognition";
            this.btn_BankCardRecognition.Size = new System.Drawing.Size(87, 23);
            this.btn_BankCardRecognition.TabIndex = 1;
            this.btn_BankCardRecognition.Text = "银行卡识别";
            this.btn_BankCardRecognition.UseVisualStyleBackColor = true;
            this.btn_BankCardRecognition.Click += new System.EventHandler(this.BankCardRecognition_Click);
            // 
            // tb_Json
            // 
            this.tb_Json.Location = new System.Drawing.Point(552, 109);
            this.tb_Json.Multiline = true;
            this.tb_Json.Name = "tb_Json";
            this.tb_Json.Size = new System.Drawing.Size(449, 235);
            this.tb_Json.TabIndex = 2;
            // 
            // 百度AI_文字识别_银行卡识别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 653);
            this.Controls.Add(this.tb_Json);
            this.Controls.Add(this.btn_BankCardRecognition);
            this.Controls.Add(this.pb_BankCard);
            this.Name = "百度AI_文字识别_银行卡识别";
            this.Text = "百度AI_文字识别_银行卡识别";
            ((System.ComponentModel.ISupportInitialize)(this.pb_BankCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_BankCard;
        private System.Windows.Forms.Button btn_BankCardRecognition;
        private System.Windows.Forms.TextBox tb_Json;
    }
}