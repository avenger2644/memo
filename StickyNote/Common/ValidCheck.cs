using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StickyNote.Common
{
    class ValidCheck
    {
        /// <summary>
        /// 检查是否为图片类型
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Image IsImage(string filePath)
        {
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(filePath);
                return img;
            }
            catch
            {
                return null;
            }
        }
    }
}
