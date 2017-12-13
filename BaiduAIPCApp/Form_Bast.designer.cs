namespace BaiduAIPCApp
{
    partial class Form_Bast
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bast));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.dockPanelUI = new WeifenLuo.WinFormsUI.DockPanel();
            this.百度身份证识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1304, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1304, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip";
            // 
            // skinEngine
            // 
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            this.skinEngine.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine.SkinStreamMain")));
            // 
            // dockPanelUI
            // 
            this.dockPanelUI.ActiveAutoHideContent = null;
            this.dockPanelUI.BackColor = System.Drawing.Color.Transparent;
            this.dockPanelUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelUI.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanelUI.Location = new System.Drawing.Point(0, 50);
            this.dockPanelUI.Name = "dockPanelUI";
            this.dockPanelUI.Size = new System.Drawing.Size(1304, 812);
            this.dockPanelUI.TabIndex = 10;
            this.dockPanelUI.Tag = "";
            this.dockPanelUI.ActiveDocumentChanged += new System.EventHandler(this.dockPanelUI_ActiveDocumentChanged);
            this.dockPanelUI.ActivePaneChanged += new System.EventHandler(this.dockPanelUI_ActivePaneChanged);
            this.dockPanelUI.ContentRemoved += new WeifenLuo.WinFormsUI.DockPanel.DockContentEventHandler(this.dockPanelUI_ContentRemoved);
   
         
            // 
            // Form_Bast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 862);
            this.Controls.Add(this.dockPanelUI);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Bast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "人工智能(AI)系统";
            this.Text = "人工智能(AI)系统";
            this.Load += new System.EventHandler(this.Form_Bast_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private WeifenLuo.WinFormsUI.DockPanel dockPanelUI;
        private System.Windows.Forms.ToolStripMenuItem 百度身份证识别ToolStripMenuItem;
    }
}

