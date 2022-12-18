using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class LongestCommonPrefixTest
    {
        [Theory]
        [InlineData("colorado", "color", "cold", "col")]
        [InlineData("a", "b", "c", "")]
        [InlineData("spot", "spotty", "spotted", "spot")]
        public void GetLonguestCommonPrefixWithSampleInput(string input1, string input2, string input3, string expected)
        {
            //arrange
            //act
            string result = LongestCommonPrefix.GetLongestCommonPrefix(input1, input2, input3);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
