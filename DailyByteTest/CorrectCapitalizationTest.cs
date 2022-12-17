using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class CorrectCapitalizationTest
    {
        [Theory]
        [InlineData("USA", true)]
        [InlineData("Calvin", true)]
        [InlineData("compUter", false)]
        [InlineData("coding", true)]
        public void IsValidCapitalizationWithSampleInput(string input, bool expected)
        {
            //arrange
            //act
            bool result = CorrectCapitalization.IsValidCapitalization(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
