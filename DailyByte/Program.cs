using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode<int> result = ReverseList.GetReverseList();
           // Console.WriteLine(result.value);

            while(result != null)
            {
                Console.WriteLine(result.value);
                result = result.next;
            }
        }
    }
}
