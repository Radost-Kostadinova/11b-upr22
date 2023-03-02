using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SpisuchenManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //new
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];

               if(command.ToLower() == "print")
                {

                    break;
                }
                int index = 0;

                switch (command)
                {
                    case "add":
                         index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        nums.Insert(index, element);

                        break;
                    case "addMany":
                        index = int.Parse(input[1]);
                        for (int i = input.Length-1; i > 1; i--)
                        {
                            element = int.Parse(input[i]);
                            nums.Insert(index,element);
                        }

                        break;
                    case "contains":
                        element = int.Parse(input[1]);
                        Console.WriteLine(nums.IndexOf(element));
                        break;
                    
                    case "remove":
                        index = int.Parse(input[1]);
                        nums.RemoveAt(index);
                        break;


                    case "shift":
                        var pos = int.Parse(input[1]);

                        break;


                    case "sumPairs":
                        break;
                }
                Console.WriteLine(string.Join(" ", nums));
            }
        }


    }


}
    
