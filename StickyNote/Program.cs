using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace StickyNote
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process curP = Process.GetCurrentProcess();
            Process[] arrP = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (arrP.Length > 1)
            {
                for (int i = 0; i < arrP.Where(s => s != curP).Count(); i++)
                {
                    if (arrP[i].CloseMainWindow() == false)
                    {
                        arrP[i].Kill();
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
