namespace StickyNote
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.ucl_For_Main1 = new StickyNote.Controls.Ucl_For_Main();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.lbl_Bottom_Time = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pic_TopMost = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Ext_Picture = new System.Windows.Forms.Panel();
            this.pic_Box_Slide = new System.Windows.Forms.PictureBox();
            this.ctdMenu_For_PicSlide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置间隔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_For_PicBox = new System.Windows.Forms.Timer(this.components);
            this.timer_For_Main = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctx_For_Notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.透明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Main.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopMost)).BeginInit();
            this.pnl_Ext_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_Slide)).BeginInit();
            this.ctdMenu_For_PicSlide.SuspendLayout();
            this.ctx_For_Notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Linen;
            this.pnl_Main.Controls.Add(this.ucl_For_Main1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 31);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(308, 508);
            this.pnl_Main.TabIndex = 0;
            // 
            // ucl_For_Main1
            // 
            this.ucl_For_Main1.BackColor = System.Drawing.Color.Transparent;
            this.ucl_For_Main1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucl_For_Main1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucl_For_Main1.Location = new System.Drawing.Point(0, 0);
            this.ucl_For_Main1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucl_For_Main1.Name = "ucl_For_Main1";
            this.ucl_For_Main1.Size = new System.Drawing.Size(308, 508);
            this.ucl_For_Main1.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.lbl_Bottom_Time);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.ForeColor = System.Drawing.Color.White;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 719);
            this.pnl_Bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(308, 22);
            this.pnl_Bottom.TabIndex = 1;
            // 
            // lbl_Bottom_Time
            // 
            this.lbl_Bottom_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Bottom_Time.AutoSize = true;
            this.lbl_Bottom_Time.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.lbl_Bottom_Time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Bottom_Time.Location = new System.Drawing.Point(143, 2);
            this.lbl_Bottom_Time.Name = "lbl_Bottom_Time";
            this.lbl_Bottom_Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Bottom_Time.Size = new System.Drawing.Size(162, 17);
            this.lbl_Bottom_Time.TabIndex = 0;
            this.lbl_Bottom_Time.Text = "今天是2016-11-21日 星期一";
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_Top.Controls.Add(this.pic_TopMost);
            this.pnl_Top.Controls.Add(this.lbl_Title);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(308, 31);
            this.pnl_Top.TabIndex = 2;
            // 
            // pic_TopMost
            // 
            this.pic_TopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_TopMost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_TopMost.Image = global::StickyNote.Properties.Resources.tuding;
            this.pic_TopMost.Location = new System.Drawing.Point(279, 3);
            this.pic_TopMost.Name = "pic_TopMost";
            this.pic_TopMost.Size = new System.Drawing.Size(25, 25);
            this.pic_TopMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TopMost.TabIndex = 1;
            this.pic_TopMost.TabStop = false;
            this.pic_TopMost.Click += new System.EventHandler(this.pic_TopMost_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(308, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "我的事项单";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Ext_Picture
            // 
            this.pnl_Ext_Picture.Controls.Add(this.pic_Box_Slide);
            this.pnl_Ext_Picture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Ext_Picture.Location = new System.Drawing.Point(0, 539);
            this.pnl_Ext_Picture.MinimumSize = new System.Drawing.Size(0, 180);
            this.pnl_Ext_Picture.Name = "pnl_Ext_Picture";
            this.pnl_Ext_Picture.Size = new System.Drawing.Size(308, 180);
            this.pnl_Ext_Picture.TabIndex = 3;
            // 
            // pic_Box_Slide
            // 
            this.pic_Box_Slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Box_Slide.Location = new System.Drawing.Point(0, 0);
            this.pic_Box_Slide.Name = "pic_Box_Slide";
            this.pic_Box_Slide.Size = new System.Drawing.Size(308, 180);
            this.pic_Box_Slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Box_Slide.TabIndex = 0;
            this.pic_Box_Slide.TabStop = false;
            this.pic_Box_Slide.MouseEnter += new System.EventHandler(this.pic_Box_Slide_MouseEnter);
            this.pic_Box_Slide.MouseLeave += new System.EventHandler(this.pic_Box_Slide_MouseLeave);
            // 
            // ctdMenu_For_PicSlide
            // 
            this.ctdMenu_For_PicSlide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂停ToolStripMenuItem,
            this.设置间隔ToolStripMenuItem});
            this.ctdMenu_For_PicSlide.Name = "ctdMenu_For_PicSlide";
            this.ctdMenu_For_PicSlide.ShowImageMargin = false;
            this.ctdMenu_For_PicSlide.Size = new System.Drawing.Size(100, 48);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            // 
            // 设置间隔ToolStripMenuItem
            // 
            this.设置间隔ToolStripMenuItem.Name = "设置间隔ToolStripMenuItem";
            this.设置间隔ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.设置间隔ToolStripMenuItem.Text = "设置间隔";
            // 
            // timer_For_PicBox
            // 
            this.timer_For_PicBox.Enabled = true;
            this.timer_For_PicBox.Interval = 3000;
            this.timer_For_PicBox.Tick += new System.EventHandler(this.timer_For_PicBox_Tick);
            // 
            // timer_For_Main
            // 
            this.timer_For_Main.Enabled = true;
            this.timer_For_Main.Interval = 500;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctx_For_Notify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "事项单";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // ctx_For_Notify
            // 
            this.ctx_For_Notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.透明ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.ctx_For_Notify.Name = "ctx_For_Notify";
            this.ctx_For_Notify.ShowImageMargin = false;
            this.ctx_For_Notify.ShowItemToolTips = false;
            this.ctx_For_Notify.Size = new System.Drawing.Size(76, 48);
            // 
            // 透明ToolStripMenuItem
            // 
            this.透明ToolStripMenuItem.Name = "透明ToolStripMenuItem";
            this.透明ToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.透明ToolStripMenuItem.Text = "透明";
            this.透明ToolStripMenuItem.Visible = false;
            this.透明ToolStripMenuItem.Click += new System.EventHandler(this.透明ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 741);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Ext_Picture);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "随手记";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopMost)).EndInit();
            this.pnl_Ext_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_Slide)).EndInit();
            this.ctdMenu_For_PicSlide.ResumeLayout(false);
            this.ctx_For_Notify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Bottom_Time;
        private System.Windows.Forms.Panel pnl_Ext_Picture;
        private System.Windows.Forms.PictureBox pic_Box_Slide;
        private System.Windows.Forms.Timer timer_For_PicBox;
        private System.Windows.Forms.ContextMenuStrip ctdMenu_For_PicSlide;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置间隔ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_For_Main;
        private Controls.Ucl_For_Main ucl_For_Main1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctx_For_Notify;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_TopMost;
        private System.Windows.Forms.ToolStripMenuItem 透明ToolStripMenuItem;


    }
}

