namespace _01.Students_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            var dict = new SortedDictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0] + " " + tokens[1];

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, 0);
                }
                dict[name] = int.Parse(tokens[2]);

                input = Console.ReadLine();
            }

             foreach (var stud in dict.Where(x => x.Value == 2))
             {
                 Console.WriteLine(stud.Key);
             }
        }
    }
}
