using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class RemoveNthToLastNode
    {
        //This question is asked by Facebook. 
        //Given a linked list and a value n, remove the nth to last node and return the resulting list.
        //
        //Ex: Given the following linked lists...
        //
        //1->2->3->null, n = 1, return 1->2->null
        //1->2->3->null, n = 2, return 1->3->null
        //1->2->3->null, n = 3, return 2->3->null

        public static ListNode<int> RemoveNthFromEnd(ListNode<int> head, int n)
        {
            var start = new ListNode<int>(0);
            var slow = start;
            var fast = start;
            start.next = head;

            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;
            return start.next;
        }

        public static LinkedList<int> myLink = new LinkedList<int>(new int[] { 1, 2, 3 });
        public static int n = 3;

        public static LinkedList<int> GetRemovedLinkedList()
        {
  
            int count = 0;
            var pointer = myLink.First;

            foreach(var i in myLink)
            {
                if (myLink.Count() - count == n)
                {
                    myLink.Remove(pointer);
                    break;
                }

                pointer = pointer.Next;
                count++;
            }

            return myLink;   
        }

        public static LinkedList<int> GetRemovedLinkedListOneLine()
        {
            myLink.Remove(myLink.Count() - n +1);
            return myLink;
        }
    }
}
