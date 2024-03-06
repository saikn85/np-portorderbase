using NP.WKR.PortOrderBase.Models.Common;
using System.Collections.Concurrent;

namespace NP.WKR.PortOrderBase.Service.Ultities;

/// <summary>
/// Internal Cache for Port Configurations
/// </summary>
public class ConfigCache
{
    private static readonly ConcurrentDictionary<ConfigType, object> _cache = [];

    public static void Add(ConfigType key, object value)
    {
        if (!_cache.TryAdd(key, value)) _cache[key] = value;
    }

    public static bool TryGet(ConfigType key, out object value) => _cache.TryGetValue(key, out value);

    public static void TryRemove(ConfigType key) => _cache.TryRemove(key, out _);

    public static void Clear() => _cache.Clear() ;
}
