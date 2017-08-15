namespace _07.Bounded_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class BoundNumbs
    {
        public static void Main()
        {
            var boundNumbs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var biggerNumb = boundNumbs.Max();
            var lowerNumb = boundNumbs.Min();

            var numbs = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= lowerNumb && numbers[i] <= biggerNumb)
                {
                    numbs.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", numbs));
        }
    }
}
