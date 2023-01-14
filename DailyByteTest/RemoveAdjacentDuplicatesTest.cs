using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class RemoveAdjacentDuplicatesTest
    {
        [Theory]
        [InlineData("abccba", "")]
        [InlineData("foobar", "fbar")]
        [InlineData("abccbefggfe", "a")]
        public void GetRemovedStringWithSampleInput(string input, string expected)
        {
            //arrange
            //act
            string result = RemoveAdjacentDuplicates.GetRemovedString(input);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
