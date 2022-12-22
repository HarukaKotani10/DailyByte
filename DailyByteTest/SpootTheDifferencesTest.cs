using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class SpootTheDifferencesTest
    {
        [Theory]
        [InlineData("foobar", "barfoot", 't')]
        [InlineData("ide", "idea", 'a')]
        [InlineData("coding", "ingcod", ' ')]
        public void GetAddedCharWithSampleInput(string s, string t, char expected)
        {
            //arrange
            //act
            char result = SpootTheDifference.GetAddedChar(s, t);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
