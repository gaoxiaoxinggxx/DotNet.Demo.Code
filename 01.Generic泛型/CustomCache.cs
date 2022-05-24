using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generic泛型
{
    public class CustomCache
    {
        private static Dictionary<string, string> _cache = new Dictionary<string, string>();
        public static string Get<T>()
        {
            string key = $"{typeof(T).FullName}";
            if (_cache.ContainsKey(key))
            {
                return _cache[key];
            }
            else
            {
                string value = $"{typeof(T).FullName}_{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")}";
                _cache.Add(key, value);
                return value;
            }
        }
    }
}
