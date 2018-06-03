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
            ((List<int>)null).NullToEmpty().IsNotNull();
        }

        [Fact]
        public void NullToEmpty_NotChange()
        {
            new[] { 1, 2, 3 }.NullToEmpty().Is(new[] { 1, 2, 3 });
        }

        [Fact]
        public void IsEmpty_true()
        {
            new List<int>().IsEmpty().IsTrue();
        }

        [Fact]
        public void IsEmpty_false()
        {
            new List<int> { 1 }.IsEmpty().IsFalse();
        }

        [Fact]
        public void IsEmpty_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => ((List<int>)null).IsEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_true()
        {
            new List<int>().IsNullOrEmpty().IsTrue();
            ((List<int>)null).IsNullOrEmpty().IsTrue();
        }

        [Fact]
        public void IsNullOrEmpty_false()
        {
            new List<int> { 1 }.IsNullOrEmpty().IsFalse();
        }

        [Fact]
        public void JoinString_Join()
        {
            new[] { "a", "b", "c" }.JoinString(",").Is("a,b,c");
            new[] { 1, 2, 3 }.JoinString("_").Is("1_2_3");
        }

        [Fact]
        public void JoinString_NotException()
        {
            new List<string>().JoinString(",").Is("");

            List<string> list = null;
            list.JoinString(",").Is("");
        }
    }
}
