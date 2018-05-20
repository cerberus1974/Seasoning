using System;

namespace Seasoning.StringExtensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !value.IsNullOrEmpty();
        }


        public static string Formats(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string Slice(this string value, int startIndex, int length)
        {
            return value.Substring(startIndex, Math.Min(value.Length - startIndex, length));
        }
    }
}
