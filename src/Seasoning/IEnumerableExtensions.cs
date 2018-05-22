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
    }
}
