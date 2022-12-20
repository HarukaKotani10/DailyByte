using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 8, 2 }, 10, true)]
        [InlineData(new int[] { 3, 9, 13, 7}, 8, false)]
        [InlineData(new int[] { 4, 2, 6, 5, 2 }, 4, true)]
        public void GetTwoSumWithSampleInput(int [] input, int target, bool expected)
        {
            //arrange
            //act
            bool result = TwoSum.GetTwoSum(input, target);

            // assert
            Assert.Equal(expected, result);
          

        }
    }
}
