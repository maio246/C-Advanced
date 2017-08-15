namespace _06.Filter_Students_by_Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class PhomeFilter
    {
        public static void Main()
        {
            string[] input;
            var result = new List<string[]>();
            while ((input = Console.ReadLine().Split())[0] != "END")
            {
                result.Add(input);
            }

            result.Where(std => std[2].StartsWith("02") || std[2].StartsWith("+3592"))
                .ToList()
                .ForEach(std => Console.WriteLine($"{std[0]} {std[1]}"));

        }
    }
}
