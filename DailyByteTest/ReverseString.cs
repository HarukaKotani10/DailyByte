using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class ReverseString
    {
        //This question is asked by Google.
        //Given a string, reverse all of its characters and return the resulting string.
        //Ex: Given the following strings...
        //“Cat”, return “taC”
        //“The Daily Byte”, return "etyB yliaD ehT”
        //“civic”, return “civic”
        public static string GetReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
