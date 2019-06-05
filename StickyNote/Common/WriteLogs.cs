using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StickyNote.Common
{
    class WriteLogs
    {
        public static void WiteEx(Exception ex)
        {
            StringBuilder strLogs = new StringBuilder();
            strLogs.AppendLine(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
            strLogs.AppendLine(ex.ToString());
            strLogs.AppendLine("--------------");

            try
            {
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "\\log.txt", strLogs.ToString());
            }
            catch { }
        }
    }
}
