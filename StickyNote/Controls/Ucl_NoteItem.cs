using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StickyNote.Properties;

namespace StickyNote.Controls
{
    public partial class Ucl_NoteItem : UserControl
    {
        private string _id;
        private string _title;
        private int _types;
        private DateTime _addtime;
        private bool _isNew;

        public Ucl_NoteItem(string id, string title, int types,DateTime addtime,bool isNew)
        {
            InitializeComponent();

            _id = id;
            _title = title;
            _types = types;
            _addtime = addtime;
            _isNew = isNew;
        }

        private void Ucl_NoteItem_Load(object sender, EventArgs e)
        {
            //设置宽度
            this.Width = Parent.Width - 20;
            //提示
            this.toolTip1.SetToolTip(this.lblInfo, _title);
            this.toolTip1.SetToolTip(this, _title);
            this.lblInfo.Text = _title;
        }

        private void Ucl_NoteItem_MouseEnter(object sender, EventArgs e)
        {
            if (this != null)
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        private void Ucl_NoteItem_MouseLeave(object sender, EventArgs e)
        {
            if (this != null)
            {
                this.BackColor = Parent.BackColor;
            }
        }

        private void 删除该事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this != null)
            {
                this.pictureBox1.Image = Resources.OK16;
                Point pt = new Point();
                pt.X = 3;
                pt.Y = 9;
                this.pictureBox1.Width = 16;
                this.pictureBox1.Height = 16;
                this.pictureBox1.Location = pt;
                this.ContextMenu = null;
                this.timer_Del.Enabled = true;
            }
        }

        private void timer_Del_Tick(object sender, EventArgs e)
        {
            if (this != null)
            {
                if (this.Width <= 15)
                {
                    this.timer_Del.Enabled = false;
                    this.timer_Del.Dispose();

                    if (this.Parent != null)
                    {
                        this.Parent.Controls.Remove(this);
                    }
                }
                else
                {
                    this.Width -= 15;
                }
            }
            else
            {
                this.timer_Del.Enabled = false;
                this.timer_Del.Dispose();
            }
        }

        private void 标记为已完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this != null)
            {

            }
        }

        public void SetSortIndex(int index)
        {
            this.lblIndex.Text = index + "";
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("[未完成事项]" + this.lblInfo.Text);
        }

        public string ID
        {
            get
            {
                return _id;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public int Types
        {
            get
            {
                return _types;
            }
        }

        public DateTime AddTime
        {
            get
            {
                return _addtime;
            }
        }

        public bool IsNew
        {
            get
            {
                return _isNew;
            }
        }
    }
}
