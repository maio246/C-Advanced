namespace _06.Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Reverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();

            var divisor = int.Parse(Console.ReadLine());

            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % divisor != 0)
                {
                    result.Add(numbers[i]);
                }
                
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
