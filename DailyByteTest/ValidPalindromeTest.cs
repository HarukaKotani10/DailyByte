using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class ValidPalindromeTest
    {
        [Theory]
        [InlineData("level", true)]
        [InlineData("algorithm", false)]
        [InlineData("A man, a plan, a canal: Panama.", true)]
        public void IsValidPalindromeWithSampleInput(string input, bool expected)
        {
            //arrange
            //act
            bool result = ValidPalindrome.IsValidPalindrome(input);

            // assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData("abcba", true)]
        [InlineData("foobof", true)]
        [InlineData("abccab", false)]
        [InlineData("housesuoah", true)]
        public void IsValidPalindromeWithRemovalWithSampleInput(string input, bool expected)
        {
            //arrange
            //act
            bool result = ValidPalindromeWithRemoval.IsValidPalindrome(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
