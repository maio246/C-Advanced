namespace _04.Average_of_Doubles
{
    using System;
    using System.Linq;

    public static class Average
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            Console.WriteLine($"{numbers.Average():f2}");
        }
    }
}
