namespace BaiduAIPCApp
{
    partial class Form_Index
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
            this.pb_Welcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Welcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Welcome
            // 
            this.pb_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Welcome.Location = new System.Drawing.Point(0, 0);
            this.pb_Welcome.Name = "pb_Welcome";
            this.pb_Welcome.Size = new System.Drawing.Size(908, 452);
            this.pb_Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Welcome.TabIndex = 0;
            this.pb_Welcome.TabStop = false;
            // 
            // Form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 452);
            this.Controls.Add(this.pb_Welcome);
            this.Name = "Form_Index";
            this.Text = "Form_Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Welcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Welcome;
    }
}