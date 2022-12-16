using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class ReverseStringTest
    {
        [Theory]
        [InlineData("Cat", "taC")]
        [InlineData("The Daily Byte", "etyB yliaD ehT")]
        [InlineData("civic", "civic")]
        public void ReverseStringTestWithInputSampleInput(string input, string expected)
        {
            //arrange
            //act
            string result = ReverseString.GetReverseString(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
