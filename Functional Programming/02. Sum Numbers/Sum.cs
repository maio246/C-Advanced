namespace _02.Sum_Numbers
{
    using System;
    using System.Linq;

    public static class Sum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
