using System;
using System.Collections.Generic;
using System.Text;

namespace Seasoning.Int32Extensions
{
    public static class Int32Extensions
    {
        public static IEnumerable<int> Times(this int value)
        {
            for (var i = 0; i < value; i++) yield return i;
        }

        public static IEnumerable<int> UpTo(this int start, int end)
        {
            for (var i = start; i <= end; i++) yield return i;
        }

        public static IEnumerable<int> DownTo(this int start, int end)
        {
            for (var i = start; i >= end; i--) yield return i;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this int value)
        {
            return !value.IsEven();
        }
    }
}
