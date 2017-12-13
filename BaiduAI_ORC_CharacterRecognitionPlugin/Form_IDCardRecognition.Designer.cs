namespace BaiduAI_ORC_CharacterRecognitionPlugin
{
    partial class Form_IDCardRecognition
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_AddPic = new System.Windows.Forms.Button();
            this.pb_PositivePic = new System.Windows.Forms.PictureBox();
            this.progressBar_ToReadDistinguish = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_showInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Side = new System.Windows.Forms.CheckBox();
            this.cb_Positive = new System.Windows.Forms.CheckBox();
            this.btn_UploadSidePic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ToDistinguish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pb_SidePic = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PositivePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1417, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "百度AI_身份证识别";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btn_AddPic
            // 
            this.btn_AddPic.Location = new System.Drawing.Point(37, 33);
            this.btn_AddPic.Name = "btn_AddPic";
            this.btn_AddPic.Size = new System.Drawing.Size(97, 23);
            this.btn_AddPic.TabIndex = 1;
            this.btn_AddPic.Text = "上传正面图片";
            this.btn_AddPic.UseVisualStyleBackColor = true;
            this.btn_AddPic.Click += new System.EventHandler(this.btn_AddPic_Click);
            // 
            // pb_PositivePic
            // 
            this.pb_PositivePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_PositivePic.BackColor = System.Drawing.Color.White;
            this.pb_PositivePic.Location = new System.Drawing.Point(6, 20);
            this.pb_PositivePic.Name = "pb_PositivePic";
            this.pb_PositivePic.Size = new System.Drawing.Size(577, 309);
            this.pb_PositivePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PositivePic.TabIndex = 2;
            this.pb_PositivePic.TabStop = false;
            // 
            // progressBar_ToReadDistinguish
            // 
            this.progressBar_ToReadDistinguish.Location = new System.Drawing.Point(136, 125);
            this.progressBar_ToReadDistinguish.Name = "progressBar_ToReadDistinguish";
            this.progressBar_ToReadDistinguish.Size = new System.Drawing.Size(288, 19);
            this.progressBar_ToReadDistinguish.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pb_PositivePic);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(26, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 344);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "9999";
            this.groupBox1.Text = "身份证正面";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tb_showInfo);
            this.groupBox2.Location = new System.Drawing.Point(800, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 360);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "识别区";
            // 
            // tb_showInfo
            // 
            this.tb_showInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_showInfo.Location = new System.Drawing.Point(6, 20);
            this.tb_showInfo.Multiline = true;
            this.tb_showInfo.Name = "tb_showInfo";
            this.tb_showInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_showInfo.Size = new System.Drawing.Size(549, 323);
            this.tb_showInfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cb_Side);
            this.groupBox3.Controls.Add(this.cb_Positive);
            this.groupBox3.Controls.Add(this.btn_UploadSidePic);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_ToDistinguish);
            this.groupBox3.Controls.Add(this.btn_AddPic);
            this.groupBox3.Controls.Add(this.progressBar_ToReadDistinguish);
            this.groupBox3.Location = new System.Drawing.Point(800, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 329);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作区";
            // 
            // cb_Side
            // 
            this.cb_Side.AutoSize = true;
            this.cb_Side.Location = new System.Drawing.Point(136, 79);
            this.cb_Side.Name = "cb_Side";
            this.cb_Side.Size = new System.Drawing.Size(72, 16);
            this.cb_Side.TabIndex = 8;
            this.cb_Side.Text = "识别反面";
            this.cb_Side.UseVisualStyleBackColor = true;
            // 
            // cb_Positive
            // 
            this.cb_Positive.AutoSize = true;
            this.cb_Positive.Checked = true;
            this.cb_Positive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Positive.Location = new System.Drawing.Point(39, 79);
            this.cb_Positive.Name = "cb_Positive";
            this.cb_Positive.Size = new System.Drawing.Size(72, 16);
            this.cb_Positive.TabIndex = 7;
            this.cb_Positive.Text = "识别正面";
            this.cb_Positive.UseVisualStyleBackColor = true;
            // 
            // btn_UploadSidePic
            // 
            this.btn_UploadSidePic.Location = new System.Drawing.Point(179, 33);
            this.btn_UploadSidePic.Name = "btn_UploadSidePic";
            this.btn_UploadSidePic.Size = new System.Drawing.Size(97, 23);
            this.btn_UploadSidePic.TabIndex = 6;
            this.btn_UploadSidePic.Text = "上传反面图片";
            this.btn_UploadSidePic.UseVisualStyleBackColor = true;
            this.btn_UploadSidePic.Click += new System.EventHandler(this.btn_UploadSidePic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "识别进度:";
            // 
            // btn_ToDistinguish
            // 
            this.btn_ToDistinguish.Location = new System.Drawing.Point(311, 33);
            this.btn_ToDistinguish.Name = "btn_ToDistinguish";
            this.btn_ToDistinguish.Size = new System.Drawing.Size(75, 23);
            this.btn_ToDistinguish.TabIndex = 4;
            this.btn_ToDistinguish.Text = "识别信息";
            this.btn_ToDistinguish.UseVisualStyleBackColor = true;
            this.btn_ToDistinguish.Click += new System.EventHandler(this.btn_ToDistinguish_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.pb_SidePic);
            this.groupBox4.Location = new System.Drawing.Point(26, 408);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 360);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "身份证反面";
            // 
            // pb_SidePic
            // 
            this.pb_SidePic.BackColor = System.Drawing.Color.White;
            this.pb_SidePic.Location = new System.Drawing.Point(6, 20);
            this.pb_SidePic.Name = "pb_SidePic";
            this.pb_SidePic.Size = new System.Drawing.Size(577, 323);
            this.pb_SidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SidePic.TabIndex = 2;
            this.pb_SidePic.TabStop = false;
            // 
            // Form_IDCardRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1417, 780);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_IDCardRecognition";
            this.Text = "百度AI_身份证识别";
            this.Load += new System.EventHandler(this.Form_IDCardRecognition_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PositivePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_SidePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btn_AddPic;
        private System.Windows.Forms.PictureBox pb_PositivePic;
        private System.Windows.Forms.ProgressBar progressBar_ToReadDistinguish;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_showInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ToDistinguish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_UploadSidePic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_SidePic;
        private System.Windows.Forms.CheckBox cb_Side;
        private System.Windows.Forms.CheckBox cb_Positive;
    }
}

