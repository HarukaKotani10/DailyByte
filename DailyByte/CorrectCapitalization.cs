using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class CorrectCapitalization
    {
        //This question is asked by Google. 
        //Given a string, return whether or not it uses capitalization correctly. 
        //A string correctly uses capitalization if all letters are capitalized, 
        //no letters are capitalized, or only the first letter is capitalized.
        //
        //Ex: Given the following strings...
        //
        //"USA", return true
        //"Calvin", return true
        //"compUter", return false
        //"coding", return true

        public static bool IsValidCapitalization(string input)
        {
            bool isLower = false;

            if (input[0].ToString() == input[0].ToString().ToLower())
                isLower = true;

            else if (input[1].ToString() == input[1].ToString().ToLower())
                isLower = true;

            for (int i=1; i < input.Length; i++)
            {
                if (input[i].ToString() == input[i].ToString().ToUpper() && isLower)
                    return false;
            }

            return true;
        }
    }
}
