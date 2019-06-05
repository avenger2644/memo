using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StickyNote.Common
{
    class Cache
    {
        private static Dictionary<string, object> _dictCache;

        public static void AddToCache(string cachekey, object cacheobj)
        {
            if (_dictCache == null)
            {
                _dictCache = new Dictionary<string, object>();
            }

            if (_dictCache.ContainsKey(cachekey))
            {
                _dictCache.Remove(cachekey);
            }

            _dictCache.Add(cachekey, cacheobj);
        }

        public static void RemoveCache(string cachekey)
        {
            if (_dictCache == null)
            {
                _dictCache = new Dictionary<string, object>();
            }

            if (_dictCache.ContainsKey(cachekey))
            {
                _dictCache.Remove(cachekey);
            }
        }

        public static object GetCache(string cachekey)
        {
            if (_dictCache == null)
            {
                _dictCache = new Dictionary<string, object>();
            }

            if (_dictCache.ContainsKey(cachekey))
            {
                return _dictCache[cachekey];
            }
            else
            {
                return null;
            }
        }
    }
}
