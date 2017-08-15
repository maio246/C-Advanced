namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EvenOrOdds
    {
        public static void Main()
        {
            var numbsRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var type = Console.ReadLine();

            var result = new List<int>();
            Action<List<int>> print = ints => Console.WriteLine(string.Join(" ", ints));

            for (int i = numbsRange[0]; i <= numbsRange[1]; i++)
            {
                if (EvenOrOdd(i) == type)
                {
                    result.Add(i);
                }
            }

            print(result);

        }

        public static string EvenOrOdd(int numb)
        {
            if (numb % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}
