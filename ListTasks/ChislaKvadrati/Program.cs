using System;
using System.Linq;
using System.Collections.Generic;

namespace ChislaKvadrati
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var result = nums.Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x)).ToList();

            Console.Write(string.Join(" ",result));

        }

        



    }
}
