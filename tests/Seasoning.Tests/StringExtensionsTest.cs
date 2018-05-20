using Seasoning.StringExtensions;
using Xunit;

namespace Seasoning.Tests
{
    public class StringExtensionsTest
    {
        [Fact]
        public void IsNullOrEmpty_EmptyIsTrue()
        {
            "".IsNullOrEmpty().IsTrue();
        }

        [Fact]
        public void IsNullOrEmpty_NullIsTrue()
        {
            ((string)null).IsNullOrEmpty().IsTrue();
        }

        [Fact]
        public void IsNullOrEmpty_NotEmptyIsFalse()
        {
            "a".IsNullOrEmpty().IsFalse();
        }

        [Fact]
        public void IsNotEmpty_NotEmptyIsTrue()
        {
            "a".IsNotNullOrEmpty().IsTrue();
        }

        [Fact]
        public void IsNotEmpty_EmptyIsFalse()
        {
            "".IsNotNullOrEmpty().IsFalse();
        }

        [Fact]
        public void IsNotEmpty_NullIsFalse()
        {
            ((string)null).IsNotNullOrEmpty().IsFalse();
        }
    }
}
