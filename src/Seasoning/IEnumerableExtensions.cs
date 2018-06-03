using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seasoning.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> values)
        {
            if (values != null) return values;

            return Enumerable.Empty<T>();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> values)
        {
            return !values.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> values)
        {
            if (values == null) return true;

            return values.IsEmpty();
        }

        public static string JoinString<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values.NullToEmpty());
        }
    }
}
