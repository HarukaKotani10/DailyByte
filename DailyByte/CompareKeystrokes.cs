using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class CompareKeystrokes
    {
        //This question is asked by Amazon. 
        //Given two strings s and t, which represents a sequence of keystrokes, 
        //where # denotes a backspace, return whether or not the sequences produce the same result.
        //
        //Ex: Given the following strings...
        //
        //s = "ABC#", t = "CD##AB", return true
        //s = "como#pur#ter", t = "computer", return true
        //s = "cof#dim#ng", t = "code", return false

        public static bool IsEqual(string  input1, string input2)
        {
            var stack1 = new Stack();
            var stack2 = new Stack();

            stack1 = GetResult(input1);
            stack2 = GetResult(input2);

            if (stack1.Count != stack2.Count || stack1.Count == 0)
                return false;

            while(stack1.Count != 0)
            {
                if (!stack1.Pop().Equals(stack2.Pop()))
                    return false;
            }

            return true;
        }

        private static Stack GetResult(string input)
        {
            var result = new Stack();

            foreach (char i in input)
            {
                if (i.Equals('#') && result.Count != 0)
                    result.Pop();
                else
                    result.Push(i);
            }

            return result;
        }
    }
}
