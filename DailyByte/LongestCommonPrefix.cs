using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class LongestCommonPrefix
    {
        //This question is asked by Microsoft. 
        //Given an array of strings, return the longest common prefix that is shared amongst all strings.
        //Note: you may assume all strings only contain lowercase alphabetical characters.
        //
        //Ex: Given the following arrays...
        //
        //["colorado", "color", "cold"], return "col"
        //["a", "b", "c"], return ""
        //["spot", "spotty", "spotted"], return "spot"

        public static string GetLongestCommonPrefix(string input1, string input2, string input3)
        {
            string result = "";
            int i = 0;
            while(i < input1.Length && i < input2.Length && i < input3.Length)
            {
                char keyword = input1[i];
                if (input2[i].Equals(keyword) && input3[i].Equals(keyword))
                    result += keyword.ToString();
                else
                    break;

                i++;
            }

            return result;
        }
    }
}
