namespace _05.Min_Number
{
    using System;
    using System.Linq;

    public static class MinNumb
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            var result = numbers
                .Where(n => n % 2 == 0)
                .ToList()
                .Min();

            Console.WriteLine($"{result:f2}");

        }
    }
}
