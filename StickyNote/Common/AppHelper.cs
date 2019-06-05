using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace StickyNote.Common
{
    class AppHelper
    {
        public static string GetCurrentWeek()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];

            return week;
        }

        /**/
        /// <summary>
        /// MD5　32位加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UserMd5(string s)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }

            return ret.PadLeft(32, '0');
        }

        #region 序列化和反序列化方法

        /// <summary>
        /// 将数据序列化成JSON串。

        /// 并完成属性标准化。

        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="type">数据类型</param>
        /// <returns></returns>
        public static string Serializer(object data)
        {
            string strResult = null;
            // 参数错误
            if (null == data)
            {
                return strResult;
            }

            // 序列化
            return JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// 将JSON串反序列化成数据。

        /// 并完成属性标准化。

        /// </summary>
        /// <param name="json">数据</param>
        /// <param name="jsonType">json数据类型</param>
        /// <param name="dataType">核心数据类型</param>
        /// <returns></returns>
        public static object Deserializer(string json, Type jsonType)
        {
            object objResult = null;
            // 参数错误
            if (string.IsNullOrEmpty(json) || jsonType == null)
            {
                return objResult;
            }

            return JsonConvert.DeserializeObject(json, jsonType);
        }
        #endregion

        public static string HttpPost(string Url, string postDataStr)
        {
            CookieContainer cookie = new CookieContainer();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            request.CookieContainer = cookie;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            response.Cookies = cookie.GetCookies(response.ResponseUri);
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public static string HttpGet(string Url, string getDataStr)
        {
            CookieContainer cookie = new CookieContainer();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (getDataStr == "" ? "" : "?") + getDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }


        public static Bitmap Httpget_Img(string Url, string getDataStr)
        {
            CookieContainer cookie = new CookieContainer();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (getDataStr == "" ? "" : "?") + getDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            Bitmap img = new Bitmap(myResponseStream);//获取图片流                 
            img.Save(GetImageAttPath());//随机名
            return img;
        }

        public static string GetImageAttPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "ImagesT\\Bing\\";
            if (!Directory.Exists(Path.GetFullPath(path)))
            {
                Directory.CreateDirectory(Path.GetFullPath(path));
            }

            return path + DateTime.Now.ToString("yyyyMMdd") + ".png";
        }

        public static void UpdateAppSettings(string key, string value)
        {
            try
            {
                string xml = AppDomain.CurrentDomain.BaseDirectory + Process.GetCurrentProcess().ProcessName + ".exe.config";
                XmlDocument doc = new XmlDocument();
                doc.Load(xml);
                XmlNodeList lstAppSNode = doc.SelectNodes("/configuration/appSettings/add");
                for (int i = 0; i < lstAppSNode.Count; i++)
                {
                    XmlNode nd = lstAppSNode[i];
                    if (nd.Attributes["key"].Value == key)
                    {
                        nd.Attributes["value"].Value = value;
                    }
                }
                doc.Save(xml);
            }
            catch (Exception ex)
            {
                WriteLogs.WiteEx(ex);
            }
        }
    }
}
