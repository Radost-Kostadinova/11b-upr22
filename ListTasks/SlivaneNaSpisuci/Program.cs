using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace SlivaneNaSpisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();

             input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                int[] temp = input[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int  j = 0;  j < temp.Length;  j++)
                {
                    result.Add(temp[i]);
                }
            }
            Console.WriteLine(string.Join(' ',result));

        }
    }
}
