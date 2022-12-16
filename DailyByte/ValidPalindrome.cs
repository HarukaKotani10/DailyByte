using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DailyByte
{
    public class ValidPalindrome
    {
        //This question is asked by Facebook.
        //Given a string, return whether or 
        //not it forms a palindrome ignoring case and non-alphabetical characters.
        //Note: a palindrome is a sequence of characters 
        //that reads the same forwards and backwards.

        // Ex: Given the following strings...
        //"level", return true
        //"algorithm", return false
        //"A man, a plan, a canal: Panama.", return true
        public static bool IsValidPalindrome(string input)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            input = rgx.Replace(input, "");
            input = input.ToLower();
            int indexLen = input.Length - 1;

            for(int i=0; i < input.Length /2; i++)
            {
                if (!input[i].Equals(input[indexLen]))
                    return false;
                indexLen--;
            }

            return true;
        }
    }
}
