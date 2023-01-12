using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DailyByte.ContainsCycle;

namespace DailyByte
{
    public class ContainsCycle
    {
        //This question is asked by Microsoft. 
        //Given a linked list, containing unique numbers, return whether or not it has a cycle.
        //Note: a cycle is a circular arrangement (i.e. one node points back to a previous node)
        //
        //Ex: Given the following linked lists...
        //
        //1->2->3->1 -> true (3 points back to 1)
        //1->2->3 -> false
        //1->1 true (1 points to itself)

      //  public static LinkedList<int> myLink = new LinkedList<int>(new int[] { 1, 2, 3, 1});

        public static bool IsContainsCycle(ListNode<int> head)
        {
            var list = new List<ListNode<int>>();

            if (head == null)
                return false;

            while (head.next != null)
            {
                if (list.Contains(head))
                    return true;

                list.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
