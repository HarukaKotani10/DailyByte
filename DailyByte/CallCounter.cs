using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class CallCounter
    {
        //This question is asked by Google. 
        //Create a class CallCounter that tracks the number of calls a client has made within the last 3 seconds. 
        //Your class should contain one method, ping(int t) that receives the current timestamp 
        //(in milliseconds) of a new call being made and returns the number of calls made within the last 3 seconds.
        //Note: you may assume that the time associated with each subsequent call to ping is strictly increasing.
        //
        //Ex: Given the following calls to ping…
        //
        //ping(1), return 1 (1 call within the last 3 seconds)
        //ping(300), return 2 (2 calls within the last 3 seconds)
        //ping(3000), return 3 (3 calls within the last 3 seconds)
        //ping(3002), return 3 (3 calls within the last 3 seconds)
        //ping(7000), return 1 (1 call within the last 3 seconds)

        public static List<int> list = new List<int>();
       
        public static void GetNumberOfCalls()
        {
            list.Add(0);
            Ping(1);
            Ping(300);
            Ping(3000);
            Ping(3002);
            Ping(7000);
        }

        public static void Ping(int t)
        {
  
            int len = list.Count() -1;
            int lastThree = t - 3000 <= 0 ? 1 : t - 3000;
            int count = 1;

            while(list[len] >= lastThree &&  len > 0)
            {
                Console.WriteLine(t);
                count++;
                len--;
            }

            list.Add(t);

            Console.WriteLine("Time Stamp: " + t);
            Console.WriteLine("Number of calls within the last 3 seconds: " + count);
            Console.WriteLine("-----------------------------------------------");
        }


    }
}
