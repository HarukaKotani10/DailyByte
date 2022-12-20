    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class TwoSum
    {
        //This question is asked by Google. 
        //Given an array of integers, return whether or not two numbers sum to a given target, k.
        //Note: you may not sum a number with itself.
        //
        //Ex: Given the following...
        //
        //[1, 3, 8, 2], k = 10, return true (8 + 2)
        //[3, 9, 13, 7], k = 8, return false
        //[4, 2, 6, 5, 2], k = 4, return true (2 + 2)

        public static bool GetTwoSum(int [] input, int target)
        {
            for(int i=0; i < input.Length-1; i++)
                for(int j=i+1; j < input.Length; j++)
                    if (input[i] + input[j] == target)
                        return true;
  
            return false;
        }
    }
}
