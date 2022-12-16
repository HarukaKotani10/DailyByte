using DailyByte;
using Xunit;

namespace DailyByteTest
{
    public class VaccumCleanerRouteTest
    {
        [Theory]
        [InlineData("LR", true)]
        [InlineData("URURD", false)]
        [InlineData("RUULLDRD", true)]
        public void IsOriginalPositionWithSampleImput(string input, bool expected)
        {
            //arrange
            //act
            bool result = VacuumCleanerRoute.IsOriginalPosition(input);

            // assert
            Assert.Equal(expected, result);

        }
    }
}
