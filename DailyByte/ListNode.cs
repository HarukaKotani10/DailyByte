using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class ListNode<T>
    {

        // Properties
        public ListNode<T> next { get; set; }
        public T value { get; set; }

        public ListNode(T value)
        {
            this.value = value;
            next = null;
        }
    }
}
