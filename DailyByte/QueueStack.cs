using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class QueueStack<T>
    {
        Queue<T> singleQueue;

        public QueueStack(){
            singleQueue = new Queue<T>();
        }
        public void Push(T item)
        {
            singleQueue.Enqueue(item);

            for(int i=1; i < singleQueue.Count(); i++)
            {
                singleQueue.Enqueue(singleQueue.Dequeue());
            }
        }

        public T Pop()
        {
            if(singleQueue.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return singleQueue.Dequeue();
        }

        public T Peek()
        {
            if (singleQueue.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return singleQueue.Peek();
        }

        public bool IsEmpty()
        {
            return singleQueue.Count() == 0;
        }
    }
}
