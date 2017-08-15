using System.Collections.Generic;
using System.Linq;

namespace _01.Sets_of_Elements
{
    using System;

    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstList = new List<int>();
            var secondList = new List<int>();

            for (int i = 0; i < input[0]; i++)
            {
                firstList.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                secondList.Add(int.Parse(Console.ReadLine()));
            }

            var longestList = Math.Max(firstList.Count, secondList.Count);

            var result = new List<int>();

            for (int i = 0; i < longestList; i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    if (secondList.Contains(firstList[i]))
                    {
                        result.Add(firstList[i]);
                    }
                }
                else
                {
                    if (firstList.Contains(secondList[i]))
                    {
                        result.Add(secondList[i]);
                    }

                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}