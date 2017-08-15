namespace _02.Students_by_First_and_Last_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentNames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new List<string>();
            while (input != "END")
            {
                var tokens = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var first = tokens[0].ToLower()[0];
                var second = tokens[1].ToLower()[0];

                if (first.CompareTo(second) < 0)
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
