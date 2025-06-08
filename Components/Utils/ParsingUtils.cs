using System.Globalization;

namespace Zaliczenie.Components.Utils;

public static class ParsingUtils
{
    public static decimal ParseDecimal(string value)
    {
        if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var dec))
        {
            return dec;
        }
        return 0;

    }
}
