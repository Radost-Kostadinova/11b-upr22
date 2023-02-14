using System;
using System.Text;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DelateNegativeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            nums.RemoveAll(x => x < 0);
            nums.Reverse();
            if(nums.Count==0)
            {
                Console.WriteLine("empty");
            }
            else 
            {
                Console.WriteLine(String.Join(" ",nums));
            }

        }
    }
}
