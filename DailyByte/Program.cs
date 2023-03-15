using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            MovingAverage m = new MovingAverage(3);
            Console.WriteLine(m.next(3)); //m.next(3) returns 3 because(3 / 1) = 3
            Console.WriteLine(m.next(5)); //m.next(5) returns 4 because(3 + 5) / 2 = 4
            Console.WriteLine(m.next(7)); //m.next(7) = returns 5 because(3 + 5 + 7) / 3 = 5
            Console.WriteLine(m.next(6)); //m.next(6) = returns 6 because(5 + 7 + 6) / 3 = 6

            CallCounter.GetNumberOfCalls();

            var head = new ListNode<int>(1);
            var node2 = new ListNode<int>(2);
            var node3 = new ListNode<int>(3);

            head.next = node2;
            node2.next = node3;

            ListNode<int> result = RemoveNthToLastNode.RemoveNthFromEnd(head, 2);
           // Console.WriteLine(result.value);

            while(result != null)
            {
              //  Console.WriteLine(result.value);    
                result = result.next;
            }
        }
    }
}
