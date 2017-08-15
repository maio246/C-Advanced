namespace _06.Find_and_Sum_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class FindInts
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<long>();

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    numbers.Add(long.Parse(input[i]));
                }
                catch
                {

                }

            }
            if (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
