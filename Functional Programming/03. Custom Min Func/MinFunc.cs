namespace _03.Custom_Min_Func
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class MinFunc
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> minValue = delegate(List<int> ints) { return ints.Min(); };

            Console.WriteLine(minValue(numbers));
        }

    }
}
