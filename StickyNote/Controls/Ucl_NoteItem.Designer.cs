namespace StickyNote.Controls
{
    partial class Ucl_NoteItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ctxMenu_For_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_Del = new System.Windows.Forms.Timer(this.components);
            this.lblIndex = new System.Windows.Forms.Label();
            this.ctxMenu_For_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblInfo.Location = new System.Drawing.Point(19, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(159, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "今天要做这样一件事情";
            this.lblInfo.MouseEnter += new System.EventHandler(this.Ucl_NoteItem_MouseEnter);
            this.lblInfo.MouseLeave += new System.EventHandler(this.Ucl_NoteItem_MouseLeave);
            // 
            // ctxMenu_For_Option
            // 
            this.ctxMenu_For_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.ctxMenu_For_Option.Name = "ctxMenu_For_Option";
            this.ctxMenu_For_Option.ShowImageMargin = false;
            this.ctxMenu_For_Option.ShowItemToolTips = false;
            this.ctxMenu_For_Option.Size = new System.Drawing.Size(128, 70);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.删除该事项ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StickyNote.Properties.Resources.dotfense;
            this.pictureBox1.Location = new System.Drawing.Point(5, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 7);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer_Del
            // 
            this.timer_Del.Interval = 1;
            this.timer_Del.Tick += new System.EventHandler(this.timer_Del_Tick);
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("微软雅黑", 5F);
            this.lblIndex.Location = new System.Drawing.Point(4, 23);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(25, 10);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "1";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ucl_NoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.ctxMenu_For_Option;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblIndex);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ucl_NoteItem";
            this.Size = new System.Drawing.Size(540, 33);
            this.Load += new System.EventHandler(this.Ucl_NoteItem_Load);
            this.MouseEnter += new System.EventHandler(this.Ucl_NoteItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Ucl_NoteItem_MouseLeave);
            this.ctxMenu_For_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu_For_Option;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Del;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;

    }
}
