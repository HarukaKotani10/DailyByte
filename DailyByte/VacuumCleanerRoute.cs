using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class VacuumCleanerRoute
    {
        //This question is asked by Amazon. 
        //Given a string representing the sequence of moves a robot vacuum makes, 
        //return whether or not it will return to its original position. 
        //The string will only contain L, R, U, and D characters, 
        //representing left, right, up, and down respectively.

        //Ex: Given the following strings...
        //"LR", return true
        //"URURD", return false
        //"RUULLDRD", return true

        public static bool IsOriginalPosition(string input)
        {
            int left = 0;
            int right = 0;
            int up = 0;
            int down = 0;

            foreach(char i in input)
            {
                switch (i)
                {
                    case 'L':
                        left++;
                        break;
                    case 'R':
                        right++;
                        break;
                    case 'U':
                        up++;
                        break;
                    default:
                        down++;
                        break;
                }
            }

            return left == right && up == down;
        }
    }
}
