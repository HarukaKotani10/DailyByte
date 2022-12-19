using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class ValidPalindromeWithRemoval
    {
        //This question is asked by Facebook. 
        //Given a string and the ability to delete at most one character, return whether or not it can form a palindrome.
        //Note: a palindrome is a sequence of characters that reads the same forwards and backwards.
        //
        //Ex: Given the following strings...
        //
        //"abcba", return true
        //"foobof", return true (remove the first 'o', the second 'o', or 'b')
        //"abccab", return false
        //"housesuoah", return true

        public static bool IsValidPalindrome(string input)
        {
            int indexLen = input.Length - 1;
            bool isRemovable = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (!input[i].Equals(input[indexLen]))
                {
                    if (input[i].Equals(input[indexLen - 1]) && isRemovable)
                    {
                        indexLen--;
                        isRemovable = false;
                    }
                        
                    else if (input[i + 1].Equals(input[indexLen]) && isRemovable)
                    {
                        i++;
                        isRemovable = false;
                    }
                        
                    else
                        return false;
                }
                
                indexLen--;
            }

            return true;
        }
    }
}
