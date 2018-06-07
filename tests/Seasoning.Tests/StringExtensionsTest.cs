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

        [Fact]
        public void Formats_CanFormat()
        {
            "{0} Can {1}".Formats("I", "Fly").Is("I Can Fly");
        }

        [Fact]
        public void Slice_Substrig()
        {
            "abcdefg".Slice(0, 2).Is("ab");
            "abcdefg".Slice(1, 2).Is("bc");
        }

        [Fact]
        public void Slice_NotException()
        {
            "abc".Slice(1, 3).Is("bc");
        }

        [Fact]
        public void Repeat_Multiplication()
        {
            "a".Repeat(5).Is("aaaaa");
            "abc".Repeat(2).Is("abcabc");
            "".Repeat(10).Is("");
        }

        [Fact]
        public void Repeat_NullIfNull()
        {
            string s = null;
            s.Repeat(5).IsNull();
        }
    }
}
