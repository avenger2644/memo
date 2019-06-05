using StickyNote.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StickyNote
{
    public partial class Main : Form
    {
        private System.Threading.Thread _setBackImage = null;

        public delegate void LayoutControlAddedEventHandler(int changeHeight);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetAppSettings();
            SetPosition();
            InitTimer();
            //SetAlpha();
            //初始化数据
            SetData();
            //初始化一个背景图
            //timer_For_PicBox_Tick(null,null);
            //委托更改自适应
            this.ucl_For_Main1.layoutAdded = new LayoutControlAddedEventHandler(LayoutAdded);
        }

        private void InitTimer()
        {
            _setBackImage = new System.Threading.Thread(SetBingImage);
            _setBackImage.IsBackground = true;
            _setBackImage.Start();
        }

        /// <summary>
        /// 设置数据
        /// </summary>
        private void SetData()
        {

        }

        private void SetBingImage()
        {
            if (Cache.GetCache("photourl") != null)
            {
                try
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "ImagesT\\Bing\\" + DateTime.Now.ToString("yyyyMMdd") + ".png";
                    if (!File.Exists(path))
                    {
                        AppHelper.Httpget_Img(Cache.GetCache("photourl").ToString(), "");
                    }
                    string tmp = Path.GetTempFileName();
                    File.Copy(path, tmp, true);
                    Image image = Image.FromFile(path);
                    this.pic_Box_Slide.Image = Image.FromFile(tmp);
                    image.Save(path + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);





                    WinAPI.SystemParametersInfo(20, 0, path + ".bmp", 0x2);
                }
                catch (Exception ex)
                {
                    WriteLogs.WiteEx(ex);
                }
            }
        }

        /// <summary>
        /// 设置配置项目
        /// </summary>
        private void SetAppSettings()
        {
            this.Opacity = 0.8;

            #region 基本配置设置
            string[] Keys = ConfigurationManager.AppSettings.AllKeys;
            string strV = "";
            foreach (string key in Keys)
            {
                strV = ConfigurationManager.AppSettings[key];
                try
                {
                    if (key == "apptitle")
                    {
                        this.lbl_Title.Text = strV;
                        this.Text = strV;
                        Cache.AddToCache(key, strV);
                    }
                    else if (key == "photodir")
                    {



                        Cache.AddToCache(key, strV);
                    }
                    else if (key == "APPBkcolor")
                    {
                        int[] arrRgb = strV.Split(',').Select(s => int.Parse(s)).ToArray();
                        Color bkColor = Color.FromArgb(arrRgb[0], arrRgb[1], arrRgb[2]);
                        this.pnl_Top.BackColor = bkColor;

                        Cache.AddToCache(key, bkColor);
                    }
                    else if (key == "photoclock")
                    {
                        int tmp;
                        if (int.TryParse(strV, out tmp))
                        {
                            this.timer_For_PicBox.Interval = tmp;
                            Cache.AddToCache(key, tmp);
                        }
                    }
                    else if (key == "ContentBkcolor")
                    {
                        int[] arrRgb = strV.Split(',').Select(s => int.Parse(s)).ToArray();
                        Color bkColor = Color.FromArgb(arrRgb[0], arrRgb[1], arrRgb[2]);
                        this.pnl_Main.BackColor = bkColor;
                        Cache.AddToCache(key, bkColor);
                    }
                    else if (key == "bakurl")
                    {
                        Cache.AddToCache(key, strV);
                    }
                    else if (key == "uid")
                    {
                        if (strV == "")
                        {
                            strV = Guid.NewGuid().ToString();
                            AppHelper.UpdateAppSettings(key, strV);
                        }
                        Cache.AddToCache(key, strV);
                    }
                    else if (key == "photourl")
                    {
                        Cache.AddToCache(key, strV);
                    }
                }
                catch (Exception ex)
                {
                    Common.WriteLogs.WiteEx(ex);
                }
            }
            #endregion

            //设置时间
            this.lbl_Bottom_Time.Text = "今天是 " + DateTime.Now.ToString("yyyy-MM-dd") + "日 " + AppHelper.GetCurrentWeek();
        }

        /// <summary>
        /// 设置窗体透明度和禁止点击
        /// </summary>
        private void SetAlpha()
        {
            //this.TopMost = true;
            Common.WinAPI.SetWindowLong(this.Handle);
            Common.WinAPI.SetLayeredWindowAttributes(this.Handle, 128);
        }

        /// <summary>
        /// 设置定位和自适应高度
        /// </summary>
        private void SetPosition()
        {
            Rectangle rect = Common.WinAPI.GetPrimaryScreenWorkingArea();

            this.Height = rect.Height;

            Point pt = new Point();
            pt.Y = 0;
            pt.X = rect.Width - this.Width;

            this.Location = pt;
        }

        /// <summary>
        /// 触发自适应
        /// </summary>
        /// <param name="changeHeight"></param>
        public void LayoutAdded(int changeHeight)
        {
            //if (this.pnl_Ext_Picture.Height - changeHeight > this.pnl_Ext_Picture.MinimumSize.Height)
            //{
            //    this.pnl_Ext_Picture.Height -= changeHeight;
            //}
            //else
            //{
            //    this.pnl_Ext_Picture.Height = this.pnl_Ext_Picture.MinimumSize.Height;
            //}
        }

        /// <summary>
        /// 时间片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_For_PicBox_Tick(object sender, EventArgs e)
        {
            try
            {
                SetPosition();
                //string[] arrImages = Directory.GetFiles("E:\\文件库\\图片\\SogouWP\\");
                //Random rd = new Random();
                //int rnNumber = rd.Next(0, arrImages.Length - 1);
                //Image img = Common.ValidCheck.IsImage(arrImages[rnNumber]);
                //if (img != null)
                //{
                //    this.pic_Box_Slide.Image = img;
                //}
            }
            catch (Exception ex)
            {
                Common.WriteLogs.WiteEx(ex);
            }
        }

        private void pic_Box_Slide_MouseEnter(object sender, EventArgs e)
        {
            this.timer_For_PicBox.Enabled = false;
        }

        private void pic_Box_Slide_MouseLeave(object sender, EventArgs e)
        {
            this.timer_For_PicBox.Enabled = true;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_TopMost_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private bool isAlpha = false;
        private void 透明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WinAPI.SetWindowLong(this.Handle);
            //WinAPI.SetLayeredWindowAttributes(this.Handle, 200);

            this.Opacity = 0.8;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Visible)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void Main_Leave(object sender, EventArgs e)
        {

        }
    }
}
