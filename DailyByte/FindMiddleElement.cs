using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class FindMiddleElement
    {
        //This question is asked by Amazon. 
        //Given a non-empty linked list, return the middle node of the list. 
        //If the linked list contains an even number of elements, return the node closer to the end.
        //Ex: Given the following linked lists...
        //
        //1->2->3->null, return 2
        //1->2->3->4->null, return 3
        //1->null, return 1

        public static int GetMiddleElement()
        {
            var myLink = new LinkedList<int>(new int[] {1});
            int middle = myLink.Count() == 1 ? 0 : myLink.Count() / 2;
            int count = 0;

            foreach(var i in myLink)
            {
                if (count == middle)
                    return i;
                count++;
            }

            return 0;
        }
    }
}
