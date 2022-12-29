using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class MergeLinkedList
    {
        //This question is asked by Apple. 
        //Given two sorted linked lists, merge them together in ascending order and return a reference to the merged list
        //
        //Ex: Given the following lists...
        //
        //list1 = 1->2->3, list2 = 4->5->6->null, return 1->2->3->4->5->6->null
        //list1 = 1->3->5, list2 = 2->4->6->null, return 1->2->3->4->5->6->null
        //list1 = 4->4->7, list2 = 1->5->6->null, return 1->4->4->5->6->7->null

        public static LinkedList<int> GetMargedLinkedList()
        {
            LinkedList<int> list1 = new LinkedList<int>(new int[] { 4, 4, 7 });
            LinkedList<int> list2 = new LinkedList<int>(new int[] { 1, 5, 6 });

            var margedList = new LinkedList<int>();
            var pointer1 = list1.First;
            var pointer2 = list2.First;

            while (pointer1 != null || pointer2 != null)
            {
                if (pointer1 == null)
                {
                    margedList.AddLast(pointer2.Value);
                    pointer2 = pointer2.Next;
                }

                else if(pointer2 == null)
                {
                    margedList.AddLast(pointer1.Value);
                    pointer1 = pointer1.Next;
                }

                else
                {
                    if (pointer1.Value < pointer2.Value)
                    {
                        margedList.AddLast(pointer1.Value);
                        pointer1 = pointer1.Next;
                    }

                    else
                    {
                        margedList.AddLast(pointer2.Value);
                        pointer2 = pointer2.Next;
                    }
                }
            }

            return margedList;   
        }
    }
}
