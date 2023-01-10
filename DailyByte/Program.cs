using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode<int> result = ReturnStartOfCycle.GetStartOfCycle();
            Console.WriteLine(result.value);

/*            foreach(var i in result)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
