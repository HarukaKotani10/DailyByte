using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class FirstUniqueCharacter
    {
        //This question is asked by Microsoft. 
        //Given a string, return the index of its first unique character. 
        //If a unique character does not exist, return -1.
        //
        //Ex: Given the following strings...
        //
        //"abcabd", return 2
        //"thedailybyte", return 1
        //"developer", return 0

        public static int GetFirstUniqueCharacterIndex(string input)
        {
            int result = -1;

            for(int i=0; i < input.Length; i++)
                if (input.Count(c => c == input[i]) == 1)
                   return i;

            return result;
            
        }
    }
}
