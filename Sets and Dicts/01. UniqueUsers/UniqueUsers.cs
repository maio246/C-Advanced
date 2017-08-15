using System.Collections.Generic;

namespace _01.UniqueUsers
{
    using System;

    public class UniqueUsers
    {
        public static void Main()
        {
            var inputUsers = int.Parse(Console.ReadLine());

            var result = new HashSet<string>();

            for (int i = 0; i < inputUsers; i++)
            {
                result.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", result));
        }
    }
}