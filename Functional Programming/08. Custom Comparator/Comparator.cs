namespace _08.Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Comparator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var odd = new List<int>();
            var even = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
                else
                {
                    odd.Add(numbers[i]);
                }
            }
            even.OrderBy(x => x);
            odd.OrderBy(x => x);

            var result = new List<int>();

            result.AddRange(even);
            result.AddRange(odd);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
