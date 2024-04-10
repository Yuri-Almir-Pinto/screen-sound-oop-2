using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Extensions;
internal static class Extensions
{
    public static string ConcatAsString<T>(this IEnumerable<T> enumerable, Func<T, string> accumulator)
    {
        var str = "";
        foreach (var item in enumerable)
        {
            str += accumulator(item);
        }
        return str;
    }
}
