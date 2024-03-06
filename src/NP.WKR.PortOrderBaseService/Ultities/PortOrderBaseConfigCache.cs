using NP.WKR.PortOrderBase.Models.Common;
using System.Collections.Concurrent;

namespace NP.WKR.PortOrderBase.Service.Ultities;

/// <summary>
/// Internal Cache for Port Configurations
/// </summary>
public class PortOrderBaseConfigCache
{
    private static readonly ConcurrentDictionary<PortOrderBaseConfigType, object> _cache = [];

    public static void Add(PortOrderBaseConfigType key, object value)
    {
        if (!_cache.TryAdd(key, value)) _cache[key] = value;
    }

    public static bool TryGet(PortOrderBaseConfigType key, out object value) => _cache.TryGetValue(key, out value);

    public static void TryRemove(PortOrderBaseConfigType key) => _cache.TryRemove(key, out _);

    public static void Clear() => _cache.Clear() ;
}
