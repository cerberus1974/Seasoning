using System;
using System.Collections.Generic;
using System.Text;

namespace Seasoning.CharExtensions
{
    public static class CharExtensions
    {
        public static string Repeat(this char value, int count)
        {
            return new string('a', count);
        }
    }
}
