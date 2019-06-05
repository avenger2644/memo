using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StickyNote.Common
{
    class WinAPI
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         );
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern long GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern int SetLayeredWindowAttributes(IntPtr Handle, int crKey, byte bAlpha, int dwFlags);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_TRANSPARENT = 0x20;
        const int WS_EX_LAYERED = 0x80000;
        const int LWA_ALPHA = 2;

        /// <summary>
        /// 此函数用于设置分层窗口透明度，常和 UpdateLayeredWindow 函数结合使用。
        /// </summary>
        /// <param name="handle">窗体的句柄Form.Handle</param>
        /// <param name="bAlpha">设置透明度，0表示完全透明，255表示不透明</param>
        public static void SetLayeredWindowAttributes(IntPtr handle, byte bAlpha)
        {
            SetLayeredWindowAttributes(handle, 0, bAlpha, LWA_ALPHA);
        }

        /// <summary>
        /// SetWindowLong是一个Windows API函数。该函数用来改变指定窗口的属性．函数也将指定的一个32位值设置在窗口的额外存储空间的指定偏移位置。
        /// </summary>
        /// <param name="handle"></param>
        public static void SetWindowLong(IntPtr handle)
        {
            SetWindowLong(handle, GWL_EXSTYLE, GetWindowLong(handle, GWL_EXSTYLE) | WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }

        /// <summary>
        /// 获取显示器的工作区。工作区是显示器的桌面区域，不包括任务栏、停靠窗口和停靠工具栏。
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public static Rectangle GetPrimaryScreenWorkingArea()
        {
            Rectangle ScreenArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            return ScreenArea;
        }
    }
}
