using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03.Periodic_Table
{
    using System;

    public class PeriodicTable
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                var elements = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var element in elements)
                {
                    result.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", result.OrderBy(x => x)));
        }
    }
}