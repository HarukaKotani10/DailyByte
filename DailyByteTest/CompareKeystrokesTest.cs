using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class CompareKeystrokesTest
    {
        [Theory]
        [InlineData("ABC#", "CD##AB", true)]
        [InlineData("como#pur#ter", "computer", true)]
        [InlineData("cof#dim#ng", "code", false)]
        public void CompareKeysstrokesWithSampleInput(string input1, string input2, bool expected)
        {
            //arrange
            //act
            bool result = CompareKeystrokes.IsEqual(input1, input2);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
