using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class ValidateCharacters
    {
        //This question is asked by Google. 
        //Given a string only containing the following characters (, ), {, }, [, and ] 
        //return whether or not the opening and closing characters are in a valid order.
        //
        //Ex: Given the following strings...
        //
        //"(){}[]", return true
        //"(({[]}))", return true
        //"{(})", return false

        public static bool IsValid(string  input)
        {
            var myStack = new Stack<Char>();
            var chars = new Dictionary<char, char>(){
                {'{', '}'},
                {'[', ']'},
                {'(', ')'}
            };

            foreach (var i in input)
            {
                if (i.Equals('(') || i.Equals('{') || i.Equals('['))
                {
                    myStack.Push(i);
                }
                else
                {
                    if (myStack.Count() == 0)
                        return false;
                    if (!chars[myStack.Pop()].Equals(i))
                        return false;
                }
            }
            return true;
        }
    }
}
