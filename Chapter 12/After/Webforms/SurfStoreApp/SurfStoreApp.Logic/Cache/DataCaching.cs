using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace SurfStoreApp.Logic.Cache
{
    public class DataCaching
    {
        private static readonly ObjectCache Cache = MemoryCache.Default;

        /// <summary>
        /// Retrieve cached item
        /// </summary>
        /// <typeparam name="T">Type of cached item</typeparam>
        /// <param name="key">Name of cached item</param>
        /// <returns>Cached item as type</returns>
        public static T Get<T>(string key) where T : class
        {
            if (Cache.Contains(key))
            {
                return (T) Cache[key];
            }

            return null;
        }

        /// <summary>
        /// Insert value into the cache using
        /// appropriate name/value pairs
        /// </summary>
        /// <typeparam name="T">Type of cached item</typeparam>
        /// <param name="objectToCache">Item to be cached</param>
        /// <param name="key">Name of item</param>
        public static void Add<T>(T objectToCache, string key) where T : class
        {
            Cache.Add(key, objectToCache, DateTime.Now.AddDays(30));
        }

        /// <summary>
        /// Remove item from cache
        /// </summary>
        /// <param name="key">Name of cached item</param>
        public static void Clear(string key)
        {
            Cache.Remove(key);
        }

        /// <summary>
        /// Gets all cached items as a list by their key.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAll()
        {
            return Cache.Select(keyValuePair => keyValuePair.Key).ToList();
        }
    }
}
