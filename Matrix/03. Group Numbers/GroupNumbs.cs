using System.Collections.Generic;

namespace _03.Group_Numbers
{
    using System;
    using System.Linq;

    public class GroupNumbs
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var groupedNumbers = new Dictionary<int, List<int>>()
            {
                { 0, new List<int>()},
                { 1, new List<int>()},
                { 2, new List<int>()}
            };

            groupedNumbers[0] = new List<int>();
            groupedNumbers[1] = new List<int>();
            groupedNumbers[2] = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var numb = Math.Abs(numbers[i]);
                if (numb % 3 == 0)
                {
                    groupedNumbers[0].Add(numbers[i]);
                }
                else if (numb % 3 == 1)
                {
                    groupedNumbers[1].Add(numbers[i]);
                }
                else if (numb % 3 == 2)
                {
                    groupedNumbers[2].Add(numbers[i]);
                }
            }

            foreach (var row in groupedNumbers)
            {
                Console.WriteLine(string.Join(" ", row.Value));
            }
        }
    }
}
