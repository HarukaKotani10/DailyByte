using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class RemoveValue
    {
        //This question is asked by Google. 
        //Given a linked list and a value, remove all nodes containing the provided value, 
        //and return the resulting list.
        //
        //Ex: Given the following linked lists and values...
        //
        //1->2->3->null, value = 3, return 1->2->null
        //8->1->1->4->12->null, value = 1, return 8->4->12->null
        //7->12->2->9->null, value = 7, return 12->2->9->null

        public static LinkedList<int> GetRemovedLinkedList()
        {
            var myLink = new LinkedList<int>(new int[] {7,12,2,9});
            int value = 7;

            while (myLink.Contains(value))
                myLink.Remove(value);

            return myLink;  
        }
    }
}
