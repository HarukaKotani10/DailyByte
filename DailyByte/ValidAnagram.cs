using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class ValidAnagram
    {
        //This question is asked by Facebook. 
        //Given two strings s and t return whether or not s is an anagram of t.
        //Note: An anagram is a word formed by reordering the letters of another word.
        //
        //Ex: Given the following strings...
        //
        //s = "cat", t = "tac", return true
        //s = "listen", t = "silent", return true
        //s = "program", t = "function", return false

        public static bool IsValidAnagram(string s, string t)
        {
            return String.Concat(s.OrderBy(c => c)).Equals(String.Concat(t.OrderBy(c => c)));
        }
    }
}
