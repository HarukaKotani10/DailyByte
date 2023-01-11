﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DailyByte.ContainsCycle;

namespace DailyByte
{
    public class ReverseList
    {
        //This question is asked by Facebook. 
        //Given a linked list, containing unique values, reverse it, and return the result.
        //
        //Ex: Given the following linked lists...
        //
        //1->2->3->null, return a reference to the node that contains 3 which points to a list that looks like the following: 3->2->1->null
        //7->15->9->2->null, return a reference to the node that contains 2 which points to a list that looks like the following: 2->9->15->7->null
        //1->null, return a reference to the node that contains 1 which points to a list that looks like the following: 1->null

        public static ListNode<int> GetReverseList()
        {
            var node1 = new ListNode<int>(1);
            var node2 = new ListNode<int>(2);
            var node3 = new ListNode<int>(3);

            node1.next = node2;
            node2.next = node3;

            ListNode<int> current = node1;
            ListNode<int> next = null;
            ListNode<int> prev = null;

            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
  
            return prev;
        }
    }
}
