using System.Collections.Generic;

namespace _03.First_Name
{
    using System;
    using System.Linq;

    public static class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var letters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new List<string>();

            result = names
                .Where(w => w.StartsWith(letters[0], StringComparison.InvariantCultureIgnoreCase) ||
                            w.StartsWith(letters[1], StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            result.OrderBy(x => x);
            if (result.Count > 0)
            {
                Console.WriteLine(result.First());
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
