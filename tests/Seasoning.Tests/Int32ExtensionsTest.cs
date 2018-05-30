using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seasoning.Int32Extensions;
using Xunit;

namespace Seasoning.Tests
{
    public class Int32ExtensionsTest
    {
        [Fact]
        public void Times_LoopSpecifiedNumberOfTimes()
        {
            5.Times().Count().Is(5);

            var sum = 0;
            5.Times().Select(x => sum += x).ToArray();
            sum.Is(10);
        }

        [Fact]
        public void Times_NotLoop()
        {
            0.Times().Count().Is(0);
            (-5).Times().Count().Is(0);
        }

        [Fact]
        public void UpTo_LoopStartNumberToEndNumber()
        {
            5.UpTo(10).Count().Is(6);

            var sum = 0;
            0.UpTo(10).Select(x => sum += x).ToArray();
            sum.Is(55);
        }

        [Fact]
        public void UpTo_NotLoop()
        {
            5.UpTo(4).Count().Is(0);
        }

        [Fact]
        public void DownTo_LoopStartNumberToEndNumber()
        {
            5.DownTo(1).Count().Is(5);

            var sum = 0;
            5.DownTo(1).Select(x => sum += x).ToArray();
            sum.Is(15);
        }

        [Fact]
        public void DonwTo_NotLoop()
        {
            5.DownTo(10).Count().Is(0);
        }

        [Fact]
        public void IsEven_EvenIsTrue()
        {
            2.IsEven().IsTrue();
        }

        [Fact]
        public void IsEven_OddIsFalse()
        {
            1.IsEven().IsFalse();
        }

        [Fact]
        public void IsOdd_OddIsTrue()
        {
            1.IsOdd().IsTrue();
        }

        [Fact]
        public void IsOdd_EvenIsFalse()
        {
            2.IsOdd().IsFalse();
        }
    }
}
