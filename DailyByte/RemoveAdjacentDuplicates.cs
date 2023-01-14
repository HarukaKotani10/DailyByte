using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class RemoveAdjacentDuplicates

    {
        //This question is asked by Facebook. 
        //Given a string s containing only lowercase letters, 
        //continuously remove adjacent characters that are the same and return the result.
        //
        //Ex: Given the following strings...
        //
        //s = "abccba", return ""
        //s = "foobar", return "fbar"
        //s = "abccbefggfe", return "a"

        public static string GetRemovedString(string input)
        {
            string result = "";
            foreach(var i in input)
            {
                if (input.Count(s => (s == i)) == 1)
                    result += i.ToString();
            }

            return result;       
        }
    }
}
