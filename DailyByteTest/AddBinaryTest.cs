using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class AddBinaryTest
    {
        [Theory]
        [InlineData("100", "1", "101")]
        [InlineData("11", "1", "100")]
        [InlineData("1", "0", "1")]
        public void GetBinaryWithSampleInput(string num1, string num2, string expected)
        {
            //arrange
            //act
            string result = AddBinary.GetBinarySum(num1, num2);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
