using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Seasoning.IEnumerableExtensions;

namespace Seasoning.Tests
{
    public class IEnumerableExtensionsTest
    {
        [Fact]
        public void NullToEmpty_Empty()
        {
            IEnumerable<int> vals = null;
            vals.NullToEmpty().IsNotNull();
        }

        [Fact]
        public void NullToEmpty_NotChange()
        {
            IEnumerable<int> vals = new[] { 1, 2, 3 };
            vals.NullToEmpty().Is(new[] { 1, 2, 3 });
        }
    }
}
