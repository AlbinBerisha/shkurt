namespace Shkurt.Helpers;

using SimpleBase;

public static class ShortIdGenerator
{
    public static string Generate()
    {
        var guid = Guid.NewGuid();
        return Base62.Default.Encode(guid.ToByteArray());
    }
}