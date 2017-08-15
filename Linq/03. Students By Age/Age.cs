namespace _03.Students_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Age
    {
        public static void Main()
        {
            var student = Console.ReadLine();
            var result = new List<string[]>();
            while (student != "END")
            {
                result.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                student = Console.ReadLine();
            }

            result
                .Where(std => int.Parse(std[2]) <= 24 && int.Parse(std[2]) >= 18)
                .Select(std => string.Join(" ", std))
                .ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
