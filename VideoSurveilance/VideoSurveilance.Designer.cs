namespace VideoSurveilance
{
   partial class VideoSurveilance
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Screenshot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.tb_Identify = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Result);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.imageBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Group);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Identify);
            this.splitContainer1.Panel2.Controls.Add(this.imageBox2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 749);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 44);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(555, 419);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Screenshot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera Frame";
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(0, 44);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(570, 419);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 44);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forground Mask";
            // 
            // btn_Screenshot
            // 
            this.btn_Screenshot.Location = new System.Drawing.Point(148, 13);
            this.btn_Screenshot.Name = "btn_Screenshot";
            this.btn_Screenshot.Size = new System.Drawing.Size(89, 23);
            this.btn_Screenshot.TabIndex = 1;
            this.btn_Screenshot.Text = "截图";
            this.btn_Screenshot.UseVisualStyleBackColor = true;
            this.btn_Screenshot.Click += new System.EventHandler(this.btn_Screenshot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "操作结果:";
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(14, 496);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(526, 250);
            this.tb_Result.TabIndex = 4;
            // 
            // tb_Identify
            // 
            this.tb_Identify.Location = new System.Drawing.Point(17, 499);
            this.tb_Identify.Multiline = true;
            this.tb_Identify.Name = "tb_Identify";
            this.tb_Identify.Size = new System.Drawing.Size(526, 250);
            this.tb_Identify.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "人脸查找结果：";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(237, 467);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(126, 21);
            this.tb_Group.TabIndex = 1;
            this.tb_Group.Text = "zlink_software";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "默认人脸库组：";
            // 
            // VideoSurveilance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 749);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VideoSurveilance";
            this.Text = "VideoSurveilance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private Emgu.CV.UI.ImageBox imageBox1;
      private System.Windows.Forms.Label label1;
      private Emgu.CV.UI.ImageBox imageBox2;
      private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Screenshot;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Identify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Group;
    }
}