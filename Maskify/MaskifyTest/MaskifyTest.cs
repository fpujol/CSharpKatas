using MaskifyConsole;
using System;
using Xunit;

namespace MaskifyTest
{
    public class MaskifyTest
    {
        [Theory]
        [InlineData("99998888","####8888")]
        [InlineData("9999","9999")]
        [InlineData("1","1")]
        [InlineData("", "")]
        public void ShouldMaskVersion1MaskString(string cc, string expected)
        {
            var result = Kata.MaskifyVersion1(cc);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("99998888", "####8888")]
        [InlineData("9999", "9999")]
        [InlineData("1", "1")]
        [InlineData("", "")]
        public void ShouldMaskVersion2MaskString(string cc, string expected)
        {
            var result = Kata.MaskifyVersion2(cc);
            Assert.Equal(expected, result);
        }
    }
}
