using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    //This question is asked by Microsoft. Design a class, MovingAverage, which contains a method, 
    //next that is responsible for returning the moving average from a stream of integers.
    //Note: a moving average is the average of a subset of data at a given point in time.
    //
    //Ex: Given the following series of events...
    //
    //// i.e. the moving average has a capacity of 3.
    //MovingAverage movingAverage = new MovingAverage(3);
    //m.next(3) returns 3 because (3 / 1) = 3
    //m.next(5) returns 4 because (3 + 5) / 2 = 4 
    //m.next(7) = returns 5 because (3 + 5 + 7) / 3 = 5
    //m.next(6) = returns 6 because (5 + 7 + 6) / 3 = 6
    public class MovingAverage
    {
        // TODO: declare any instance variables you require.

        private int _size;
        private Queue<int> _queue;
        private int _sum;
        public MovingAverage(int size)
        {
            _size = size;
            _queue = new Queue<int>();
            _sum = 0;
        }

        /**
         * Adds `val` to the stream of numbers
         * and returns the current average of the numbers.
         */
        public double next(int val)
        {
            if(_queue.Count == _size)
                _sum -= _queue.Dequeue();

            _sum += val;
            _queue.Enqueue(val);
    
            return (double) _sum / _queue.Count;
        }

    }
}
