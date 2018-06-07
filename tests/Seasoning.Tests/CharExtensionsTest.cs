using System;
using System.Collections.Generic;
using System.Text;
using Seasoning.CharExtensions;
using Xunit;

namespace Seasoning.Tests
{
    public class CharExtensionsTest
    {
        [Fact]
        public void Repeat_Multiplication()
        {
            'a'.Repeat(5).Is("aaaaa");
        }
    }
}
