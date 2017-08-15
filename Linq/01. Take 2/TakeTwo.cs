namespace _01.Take_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Where(n => n >= 10 && n <= 20).Distinct().Take(2).ToList().ForEach(n => Console.Write(n + " "));

            Console.WriteLine();
        }
    }
}
