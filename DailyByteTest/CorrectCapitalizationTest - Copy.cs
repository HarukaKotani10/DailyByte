using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class ValidateCharactersTest
    {
        [Theory]
        [InlineData("(){}[]", true)]
        [InlineData("(({[]}))", true)]
        [InlineData("{(})", false)]
        public void IsValidCapitalizationWithSampleInput(string input, bool expected)
        {
            //arrange
            //act
            bool result = ValidateCharacters.IsValid(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
