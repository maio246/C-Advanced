namespace _04.Add_VAT
{
    using System;
    using System.Linq;

    public static class VAT
    {
        public static void Main()
        {
            var numbers = Console.ReadLine();

            numbers.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *= 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:n2}"));
        }
    }
}
