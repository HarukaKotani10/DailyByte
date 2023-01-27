using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {

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
