﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DailyByte.ContainsCycle;

namespace DailyByte
{
    public class ReturnStartOfCycle
    {
        //This question is asked by Apple. 
        //Given a potentially cyclical linked list where each value is unique, 
        //return the node at which the cycle starts. If the list does not contain a cycle, return null.
        //
        //Ex: Given the following linked lists...
        //
        //1->2->3, return null
        //1->2->3->4->5->2 (5 points back to 2), return a reference to the node containing 2
        //1->9->3->7->7 (7 points to itself), return a reference to the node containing 7
        
        public static ListNode<int> GetStartOfCycle(ListNode<int> head)
        {
            var list = new List<ListNode<int>>();
          
            while (head != null)
            {
                if (list.Contains(head))
                    return head;

                list.Add(head);
                head = head.next;
            }

            return null;
        }
    }
}
