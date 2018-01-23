using System;
using Xunit;

namespace Tik.Travis.Lib.Tests
{
    public class SampleTests
    {
        [Theory(DisplayName = "Sample_Plus")]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(3, 1, 4)]
        [InlineData(100, 1, 101)]
        public void Plus(int a, int b, int aspected)
        {
            //var a = 1;
            var result = a + b;
            Assert.Equal(aspected, a + b);
        }
    }
}
