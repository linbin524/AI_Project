using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.WinFormPlugin;

namespace BaiduAI_ORC_CharacterRecognitionPlugin
{
    public partial class Form_Test : FormInit
    {
        public Form_Test()
        {
            InitializeComponent();
            base.PBar = this.toolStrip1;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
