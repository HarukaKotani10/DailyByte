using System;

namespace DailyByte
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = ContainsCycle.IsContainsCycle();
            Console.WriteLine(result);

/*            foreach(var i in result)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
