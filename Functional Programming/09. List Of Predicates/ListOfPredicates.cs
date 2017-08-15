namespace _09.List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ListOfPredicates
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbers = new HashSet<int>();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < dividers.Length; j++)
                {
                    if (i % dividers[j] == 0)
                    {
                        numbers.Add(i);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
