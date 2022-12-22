using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class FirstUniqueCharacterTest
    {
        [Theory]
        [InlineData("abcabd", 2)]
        [InlineData("thedailybyte", 1)]
        [InlineData("developer", 0)]
        public void GetFirstUniqueCharacterIndexWithSampleInput(string input, int expected)
        {
            //arrange
            //act
            int result = FirstUniqueCharacter.GetFirstUniqueCharacterIndex(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
