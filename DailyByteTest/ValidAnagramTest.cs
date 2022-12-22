using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class ValidAnagramTest
    {
        [Theory]
        [InlineData("cat", "tac",  true)]
        [InlineData("listen", "silent", true)]
        [InlineData("program", "function", false)]
        public void IsValidAnagramWithSampleInput(string s, string t, bool expected)
        {
            //arrange
            //act
            bool result = ValidAnagram.IsValidAnagram(s, t);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
