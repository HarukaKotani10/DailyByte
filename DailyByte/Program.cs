using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MergeLinkedList.GetMargedLinkedList();

            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
