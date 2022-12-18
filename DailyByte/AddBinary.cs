using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class AddBinary
    {
        //This question is asked by Apple. 
        //Given two binary strings (strings containing only 1s and 0s) return their sum (also as a binary string).
        //Note: neither binary string will contain leading 0s unless the string itself is 0
        //
        //Ex: Given the following binary strings...
        //
        //"100" + "1", return "101"
        //"11" + "1", return "100"
        //"1" + "0", return  "1"

        public static string GetBinarySum(string  num1, string num2)
        {
            return Convert.ToString(Convert.ToInt32(num1, 2) + Convert.ToInt32(num2, 2), 2);
        }
    }
}
