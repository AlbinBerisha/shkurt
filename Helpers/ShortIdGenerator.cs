using SimpleBase;

namespace Shkurt.Helpers;

public static class ShortIdGenerator
{
    public static string Generate()
    {
        var guid = Guid.NewGuid();
        return Base62.Default.Encode(guid.ToByteArray())[..7];
    }
}