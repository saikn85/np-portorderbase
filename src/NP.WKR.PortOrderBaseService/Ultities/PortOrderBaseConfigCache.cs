using Microsoft.Extensions.Caching.Memory;

namespace NP.WKR.PortOrderBase.Service.Ultities
{
    public class PortOrderBaseConfigCache
    {
        private static readonly MemoryCache _cache = new(new MemoryCacheOptions());

        public static void Add(string key, object value, TimeSpan absoluteExpirationRelativeToNow) => _cache.Set(key, value, new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = absoluteExpirationRelativeToNow
        });

        public static bool TryGet(string key, out object value) => _cache.TryGetValue(key, out value);

        public static void Remove(string key) => _cache.Remove(key);

        public static void Clear() => _cache.Dispose();
    }
}
