using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DailyByte
{
    public class JewelsAndStones
    {
        //This question is asked by Amazon. 
        //Given a string representing your stones and another string representing a list of jewels, 
        //return the number of stones that you have that are also jewels.
        //
        //Ex: Given the following jewels and stones...
        //
        //jewels = "abc", stones = "ac", return 2
        //jewels = "Af", stones = "AaaddfFf", return 3
        //jewels = "AYOPD", stones = "ayopd", return 0

        public static int GetNumberOfStones(string jewels, string stones)
        {
            int count = 0;

            foreach(char i in stones)
            {
                if (jewels.Contains(i))
                    count++;
            }

            return count;
        }

        public static int GetNumberOfStonesLinq(string jewels, string stones)
        {
            return stones.Count(stone => jewels.Contains(stone));
        }
    }
}
