﻿using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode<int>(1);
            var node2 = new ListNode<int>(2);
            var node3 = new ListNode<int>(3);

            head.next = node2;
            node2.next = node3;

            ListNode<int> result = ReverseList.GetReverseList(head);
           // Console.WriteLine(result.value);

            while(result != null)
            {
                Console.WriteLine(result.value);
                result = result.next;
            }
        }
    }
}
