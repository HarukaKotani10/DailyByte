using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class IntersectionOfNumbersTest
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 4, 2 }, new int[] { 2, 4 }, new int[] { 2, 4 })]
        [InlineData(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3 }, new int[] { 3 })]
        [InlineData(new int[] { 2, 4, 6, 8 }, new int[] { 1, 3, 5, 7 }, new int[] {})]
        public void GetIintersectionWithSampleInputLinq(int[] nums1, int[] nums2, int [] expected)
        {
            //arrange
            //act
            int [] result = IntersectionOfNumbers.GetIintersectionLinq(nums1, nums2);

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 4, 2 }, new int[] { 2, 4 }, new int[] { 2, 4 })]
        [InlineData(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3 }, new int[] { 3 })]
        [InlineData(new int[] { 2, 4, 6, 8 }, new int[] { 1, 3, 5, 7 }, new int[] { })]
        public void GetIintersectionWithSampleInput(int[] nums1, int[] nums2, int[] expected)
        {
            //arrange
            //act
            int[] result = IntersectionOfNumbers.GetIintersection(nums1, nums2);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
