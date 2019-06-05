using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StickyNote.Common;
using System.Web;
using System.Diagnostics;

namespace StickyNote.Controls
{
    public partial class Ucl_For_Main : UserControl
    {
        private bool isAdding;
        private bool isRemoving;
        private bool isProcessing;
        private System.Timers.Timer _tm;

        public StickyNote.Main.LayoutControlAddedEventHandler layoutAdded;

        public Ucl_For_Main()
        {
            InitializeComponent();
        }

        private void Ucl_For_Main_Load(object sender, EventArgs e)
        {
            InitData();
            AbleFlowLayout();

            _tm = new System.Timers.Timer();
            _tm.Elapsed += _tm_Elapsed;
            _tm.Enabled = true;
            _tm.AutoReset = true;
            _tm.Interval = 2000;
            _tm.Start();
        }

        void _tm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer_SyncData_Tick();
        }

        private void InitData()
        {
            if (Process.GetCurrentProcess().ProcessName != "devenv")
            {
                flowLayoutPanel1.ControlRemoved -= flowLayoutPanel1_ControlRemoved;
                flowLayoutPanel1.ControlAdded -= flowLayoutPanel1_ControlAdded;
                this.flowLayoutPanel1.Controls.Clear();
                DBUtil.Note_Main main = new DBUtil.Note_Main();
                DataSet ds = main.GetList("State=0 order by addtime desc");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Ucl_NoteItem item = new Ucl_NoteItem(ds.Tables[0].Rows[i]["ID"].ToString(), ds.Tables[0].Rows[i]["Content"].ToString(), Convert.ToInt32(ds.Tables[0].Rows[i]["State"]), Convert.ToDateTime(ds.Tables[0].Rows[i]["AddTime"]), false);
                        this.flowLayoutPanel1.Controls.Add(item);
                    }
                }
                flowLayoutPanel1.ControlRemoved += flowLayoutPanel1_ControlRemoved;
                flowLayoutPanel1.ControlAdded += flowLayoutPanel1_ControlAdded;
            }
        }

        private void AbleFlowLayout()
        {
            int index = 0;
            Ucl_NoteItem noteitem = null;

            foreach (Control c in this.flowLayoutPanel1.Controls)
            {
                c.Margin = new Padding(0);

                index++;
                noteitem = c as Ucl_NoteItem;
                if (noteitem != null)
                {
                    noteitem.SetSortIndex(index);
                }
            }

            if (this.flowLayoutPanel1.Controls.Count == 0)
            {
                this.flowLayoutPanel1.Visible = false;
            }
            else
            {
                this.flowLayoutPanel1.Visible = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.textBox1.Text.Trim() != "")
            {
                Ucl_NoteItem item = new Ucl_NoteItem(Guid.NewGuid().ToString(), this.textBox1.Text.Trim(), 0, DateTime.Now, true);
                this.flowLayoutPanel1.Controls.Add(item);
                this.textBox1.Text = "";
            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            isAdding = true;

            Ucl_NoteItem noteitem = null;
            #region 保存到数据库
            if (Cache.GetCache("uid") != null)
            {
                string id;
                string title;
                int types;
                DateTime addTime;
                bool isNew;
                DBUtil.Note_Main main = new DBUtil.Note_Main();
                noteitem = e.Control as Ucl_NoteItem;
                if (noteitem != null)
                {
                    id = noteitem.ID;
                    title = noteitem.Title;
                    types = noteitem.Types;
                    addTime = noteitem.AddTime;
                    isNew = noteitem.IsNew;


                    main.ID = id;
                    main.AddRenID = Cache.GetCache("uid").ToString();
                    main.State = types;
                    main.Content = title;
                    main.AddTime = addTime.ToString("yyyy-MM-dd HH:mm:ss");

                    if (isNew)
                    {
                        main.Add();
                    }
                }
            }
            #endregion

            AbleFlowLayout();

            if (layoutAdded != null)
            {
                layoutAdded(e.Control.Height);
            }

            isAdding = false;
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            isRemoving = true;

            #region 保存到数据库
            DBUtil.Note_Main main = new DBUtil.Note_Main();
            Ucl_NoteItem noteitem = e.Control as Ucl_NoteItem;
            if (noteitem != null)
            {
                main.GetModel(noteitem.ID);
                if (main.ID == noteitem.ID)
                {
                    main.State = 2;
                    main.Update();
                }
            }
            #endregion

            AbleFlowLayout();

            isRemoving = false;
        }

        private void timer_SyncData_Tick()
        {
            if (isProcessing || isRemoving || isAdding)
            {
                return;
            }

            isProcessing = true;

            if (Cache.GetCache("bakurl") == null)
            {
                return;
            }

            if (Cache.GetCache("uid") == null)
            {
                return;
            }

            try
            {
                List<StickyNote.DBUtil.Note_Main> lst = new List<StickyNote.DBUtil.Note_Main>();
                StickyNote.DBUtil.Note_Main mm = new StickyNote.DBUtil.Note_Main();
                DataSet ds = mm.GetList("1=1 order by addtime desc");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        StickyNote.DBUtil.Note_Main m = new StickyNote.DBUtil.Note_Main();
                        m.GetModel(r["ID"].ToString());
                        if (m.ID == r["ID"].ToString())
                        {
                            lst.Add(m);
                        }
                    }
                }
                bool change = false;
                string cur = DateTime.Now.ToString("yyyyMMddHHmmss");
                string key = "Imfromlerioapplication001";
                string uid = Cache.GetCache("uid").ToString();
                string sign = AppHelper.UserMd5(uid + "(●￣(ｴ)￣●)" + key + "(●￣(ｴ)￣●)" + cur);
                string data = AppHelper.Serializer(lst);
                string result = AppHelper.HttpPost(Cache.GetCache("bakurl").ToString(), "data=" + HttpUtility.UrlEncode(data) + "&cur=" + cur + "&uid=" + uid + "&key=" + key + "&sign=" + sign + "&md=sync");
                object lstObj = AppHelper.Deserializer(result, typeof(System.Collections.Generic.List<StickyNote.DBUtil.Note_Main>));
                if (lstObj != null)
                {
                    System.Collections.Generic.List<StickyNote.DBUtil.Note_Main> lstData = lstObj as System.Collections.Generic.List<StickyNote.DBUtil.Note_Main>;
                    if (lstData != null)
                    {
                        foreach (StickyNote.DBUtil.Note_Main m in lstData)
                        {
                            StickyNote.DBUtil.Note_Main mc = new StickyNote.DBUtil.Note_Main();
                            mc.GetModel(m.ID);
                            if (mc.ID != m.ID)
                            {
                                m.Add();
                                change = true;
                            }
                        }
                    }
                }
                if (change)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate { InitData(); }));
                    }
                    else
                    {
                        InitData();
                    }
                }
            }
            catch (Exception ex) { WriteLogs.WiteEx(ex); }

            isProcessing = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
