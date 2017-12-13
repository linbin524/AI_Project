
using AOP.Common;
using AOP.Common.WinForm;
using AOP.Core.DBData;
using AOP.Data;
using AOP.Model;
using AOP.Plugin.WinFormPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace BaiduAIPCApp
{
    public partial class Form_Bast : DockContent
    {
        Dictionary<string, PluginInfo> plugins = new Dictionary<string, PluginInfo>();//存储已经加载的菜单信息
        List<string> loadedPlugins = new List<string>();//存储已经显示出来的窗体信息，就意思是你别再显示了
        Dictionary<string, ToolStripItem> loadedBars = new Dictionary<string, ToolStripItem>();//存储已经显示出来的工具栏  
        private UserInfo userInfo = null;


        public  List<ToolPlugin> AllPluginList= new List<ToolPlugin>();
        public Form_Bast()
        {

            InitializeComponent();


            List<ToolPlugin> pluginList = new List<ToolPlugin>(); ;

            pluginList.Add(new ToolPlugin() { NameSpace="BaiduAI_ORC_CharacterRecognitionPlugin",DisplayName="百度身份证识别",ClassName= "Form_IDCardRecognition", ExtendName="dll",ID=1,Pid=0 });
            AllPluginList = pluginList;
            string error = "";
            CreateTreeTable(pluginList, 0, menuStrip, out error);

            SkinEngineExtension.SetSkin(this, skinEngine);
            ShowLogoIndex();//显示欢迎界面

        }

        #region 菜单、工具栏
        /// <summary>
        /// 添加子菜单
        /// </summary>
        /// <param name="text">要显示的文字，如果为 - 则显示为分割线</param>
        /// <param name="cms">要添加到的子菜单集合</param>
        /// <param name="callback">点击时触发的事件</param>
        /// <returns>生成的子菜单，如果为分隔条则返回null</returns>

        ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection cms, EventHandler callback)
        {
            if (text == "-")
            {
                ToolStripSeparator tsp = new ToolStripSeparator();
                cms.Add(tsp);
                return null;
            }
            else if (!string.IsNullOrEmpty(text))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(text);
                tsmi.Tag = text + "TAG";
                tsmi.Image = ImageHelper.GetImage(System.Environment.CurrentDirectory + "\\ICon\\y1.ico");
                if (callback != null) tsmi.Click += callback;
                cms.Add(tsmi);

                return tsmi;
            }

            return null;
        }

        void MenuClicked(object sender, EventArgs e)
        {
            //以下主要是动态生成事件并打开窗体

            //((sender as ToolStripMenuItem).Tag)强制转换

            //ObjectHandle t = Activator.CreateInstance("WinForms", "WinForms.Form2");
            //Form f = (Form)t.Unwrap();
            //f.ShowDialog();
            MessageBox.Show("打开窗体了" + sender);

        }


        #endregion

        #region 树形递归菜单


        /// <summary>
        /// 纯粹子类数据
        /// </summary>
        public bool CreateTreeTable(List<ToolPlugin> list, int rootId, MenuStrip treeMenu, out string error)
        {
            bool isSuccessedCreate = false;
            error = "";

            try
            {
                ToolPlugin root = list.Where(x => x.Pid == rootId).FirstOrDefault();//一定保证有数据，要不然之后功能实现都会错

                if (root != null)
                {
                    BindMenu(list.OrderBy(x => x.Sort).ToList(), rootId);
                    treeMenu = menuStrip;
                    isSuccessedCreate = true;
                }

            }
            catch (Exception ex)
            {

                error += ex.ToString();
            }

            return isSuccessedCreate;
        }


        private void BindMenu(List<ToolPlugin> list, int rootId)
        {


            if (list != null)
            {

                if (list.Count > 0)
                {

                    List<ToolPlugin> dataList = list.Where(x => x.Pid == rootId).OrderBy(x => x.Sort).ToList();

                    if (dataList != null)
                    {

                        if (dataList.Count > 0)
                        {
                            foreach (ToolPlugin pt in dataList)
                            {
                                ToolStripMenuItem subItem1;
                                subItem1 = AddContextMenu(pt.DisplayName, menuStrip.Items, pt, null);
                                PluginInfo plugin = new PluginInfo();
                                plugin.ClassName = pt.ClassName;
                                plugin.DisplayName = pt.DisplayName;
                                plugin.Extends = pt.ExtendName;
                                plugin.NameSpace = pt.NameSpace;

                                subItem1.Click += new EventHandler((object sender, EventArgs e) =>
                               {
                                   if (!string.IsNullOrWhiteSpace(plugin.NameSpace))
                                       EventShowForm(plugin, sender, e);
                                   //else
                                   //  MenuClicked(sender,e);

                               });
                                GetSubMenu(pt.ID, list,subItem1);
                            }


                        }
                    }

                }

            }


        }

        private ToolStripMenuItem GetSubMenu(int pid, List<ToolPlugin> list, ToolStripMenuItem tempSubItem)
        {

            List<ToolPlugin> dataList = list.Where(x=>x.Pid==pid).ToList();

            if (dataList != null)
            {

                if (dataList.Count > 0)
                {

                    foreach (ToolPlugin pt in dataList)
                    {
                        ToolStripMenuItem subItemTool;
                        subItemTool = AddContextMenu(pt.DisplayName, tempSubItem.DropDownItems, pt, null);
                        PluginInfo plugin = new PluginInfo();
                        plugin.ClassName = pt.ClassName;
                        plugin.DisplayName = pt.DisplayName;
                        plugin.Extends = pt.ExtendName;
                        plugin.NameSpace = pt.NameSpace;

                        subItemTool.Click += new EventHandler((object sender, EventArgs e) =>
                        {
                            if (!string.IsNullOrWhiteSpace(plugin.NameSpace))
                                EventShowForm(plugin, sender, e);

                        });
                        GetSubMenu(pt.ID, list, subItemTool);
                    }

                }

            }

            return tempSubItem;
        }

        /// <summary>
        /// 添加子菜单
        /// </summary>
        /// <param name="text">要显示的文字，如果为 - 则显示为分割线</param>
        /// <param name="cms">要添加到的子菜单集合</param>
        /// <param name="callback">点击时触发的事件</param>
        /// <returns>生成的子菜单，如果为分隔条则返回null</returns>

        private ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection cms, ToolPlugin plugin, EventHandler callback)
        {
            if (text == "-")
            {
                ToolStripSeparator tsp = new ToolStripSeparator();
                cms.Add(tsp);
                return null;
            }
            else if (!string.IsNullOrEmpty(text))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(text);
                tsmi.Tag = text + "TAG";

                if (!string.IsNullOrEmpty(plugin.Pic))
                {
                    try
                    {
                        tsmi.Image = ImageHelper.GetImage(System.Environment.CurrentDirectory + "\\ICon\\" + plugin.Pic);
                    }
                    catch
                    {
                    }
                }

                if (callback != null) tsmi.Click += callback;
                cms.Add(tsmi);

                return tsmi;
            }

            return null;
        }


        #endregion

        #region 插件事件
        /// <summary>
        /// 菜单按钮触发事件
        /// </summary>
        /// <param name="plugin">插件信息</param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EventShowForm(PluginInfo plugin, object sender, EventArgs e)
        {
            //反射菜单对应的窗体 
            string path = Application.StartupPath + "\\";


            Assembly ab = Assembly.LoadFrom(path + plugin.NameSpace + "." + plugin.Extends);

            Type[] types = ab.GetTypes();
            foreach (Type t in types)
            {
                if (t.GetInterface("IPlugin") != null && t.Name == plugin.ClassName)
                {
                    //判断该类是否已经加载 
                    if (loadedPlugins.Contains(t.FullName))
                        return;
                    
                        //根据菜单信息 反射窗体
                        IPlugin obj = (IPlugin)ab.CreateInstance(t.FullName);

                        obj.ShowDlg(this.dockPanelUI, sender.ToString());
                   
                    //显示成功之后 存入信息
                    loadedPlugins.Add(t.FullName);

                    //显示工具栏  选项卡切换事件，导致获取得到按钮是集合是空的
                    ToolStripItemCollection childbar = obj.BaseBar.Items;

                    if (loadedBars.Count > 0)
                    {
                        //存储已经显示出来的工具栏 
                        if (!loadedBars.ContainsKey(sender.ToString()))
                        {
                            if (childbar.Count > 0)
                            {
                                loadedBars.Add(sender.ToString(), childbar[0]);
                            }
                        }
                    }
                    else
                    {

                        loadedBars.Add(sender.ToString(), childbar[0]);
                    }

                    // this.toolStrip.Visible = true;
                    toolStrip.Items.Clear();
                    this.toolStrip.Items.AddRange(childbar);//执行这一步，内容会被清空，所以要在这之前写入



                }

            }
                 
        }
        #endregion

        #region 选项卡
        /// <summary>
        /// 关闭选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dockPanelUI_ContentRemoved(object sender, DockContentEventArgs e)
        {
            //在关闭一个选项卡的时候把这个信息从集合中移除掉
            if (loadedPlugins.Contains(e.Content.DockHandler.Form.GetType().FullName))
            {
                loadedBars.Remove(e.Content.DockHandler.TabText);
                loadedPlugins.Remove(e.Content.DockHandler.Form.GetType().FullName);
            }
        }


        /// <summary>
        /// 切换选项卡，关闭选项卡之后，又会调到这个事件里面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dockPanelUI_ActiveDocumentChanged(object sender, EventArgs e)
        {
            try
            {
                if (loadedBars.Count > 0)
                {
                    #region 执行
                    if (loadedBars.ContainsKey(dockPanelUI.ActiveDocument.DockHandler.TabText))
                    {
                        //ToolStrip activeBar = loadedBars[dockPanelUI1.ActiveDocument.DockHandler.TabText];//在集合中找到这个工具栏 
                        ToolStrip activeBar = new ToolStrip();
                        foreach (KeyValuePair<string, ToolStripItem> k in loadedBars)
                        {
                            if (k.Key == dockPanelUI.ActiveDocument.DockHandler.TabText)
                                activeBar.Items.Add(k.Value);
                        }
                        if (activeBar != null || activeBar.Items.Count < 1)
                        {
                            toolStrip.Items.Clear();
                            this.toolStrip.Items.AddRange(activeBar.Items);
                        }
                    }
                    #endregion
                }
                else
                {

                    this.toolStrip.Items.Clear();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void dockPanelUI_ActivePaneChanged(object sender, EventArgs e)
        {

        }
        #endregion

        public int index = 0;
        private void 异常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index++;
            throw new Exception("自定义异常！" + index.ToString());
        }

        private void Form_Bast_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 显示欢迎界面，请先设置Index WindowState 最大化操作
        /// </summary>
        public void ShowLogoIndex()
        {


            Form_Index frmX = new Form_Index();

            frmX.Show(this.dockPanelUI);

            frmX.Dock = DockStyle.Fill;

            frmX.TopLevel = false;

            frmX.FormBorderStyle = FormBorderStyle.None;


            this.dockPanelUI.Text = frmX.Text;

            this.dockPanelUI.Controls.Add(frmX);

            //DockPanel panelX = new DockPanel();

            //panelX = this.dockPanelUI.AddPanel(DockingStyle.Left);
        }

    }
}
