namespace _01.Sort_Even_Numbers
{
    using System;
    using System.Linq;

    public static class SortedNumbs
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToArray()));
        }
    }
}
