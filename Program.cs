using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> empty_list = new List<object>();
            empty_list.Add(7);
            empty_list.Add(28);
            empty_list.Add(-1);
            empty_list.Add(true);
            empty_list.Add("chair");
            int sum = 0;
            foreach(var entry in empty_list)
            {
                Console.WriteLine(entry);
                if(entry is int)
                {
                    Console.WriteLine(entry + " is int ");
                    sum += Convert.ToInt32(entry);
                }
            }
            Console.WriteLine(sum + " is sum ");
        }
    }
}
