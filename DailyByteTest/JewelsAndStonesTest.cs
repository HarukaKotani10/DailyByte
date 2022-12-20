using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class JewelsAndStonesTest
    {
        [Theory]
        [InlineData("abc", "ac", 2)]
        [InlineData("Af", "AaaddfFf", 3)]
        [InlineData("AYOPD", "ayopd", 0)]

        public void GetNumberOfStonesWithSampleInput(string jewels, string stones, int expected)
        {
            //arrange
            //act
            int result = JewelsAndStones.GetNumberOfStones(jewels, stones);

            // assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData("abc", "ac", 2)]
        [InlineData("Af", "AaaddfFf", 3)]
        [InlineData("AYOPD", "ayopd", 0)]
        public void GetNumberOfStonesWithSampleInputLinq(string jewels, string stones, int expected)
        {
            //arrange
            //act
            int result = JewelsAndStones.GetNumberOfStonesLinq(jewels, stones);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
