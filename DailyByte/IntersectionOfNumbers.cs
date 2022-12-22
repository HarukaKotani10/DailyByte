using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class IntersectionOfNumbers
    {
        //This question is asked by Google. 
        //Given two integer arrays, return their intersection.
        //Note: the intersection is the set of elements that are common to both arrays.
        //
        //Ex: Given the following arrays...
        //
        //nums1 = [2, 4, 4, 2], nums2 = [2, 4], return [2, 4]
        //nums1 = [1, 2, 3, 3], nums2 = [3, 3], return [3]
        //nums1 = [2, 4, 6, 8], nums2 = [1, 3, 5, 7], return []

        public static int [] GetIintersectionLinq(int [] nums1, int [] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }

        public static int[] GetIintersection(int[] nums1, int[] nums2)
        {
            var list = new List<int>();

            foreach(int i in nums2)
            {
                if (nums1.Contains(i) && !list.Contains(i))
                    list.Add(i);
            }
            return list.ToArray();
        }
    }
}
