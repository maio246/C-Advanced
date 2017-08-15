using System.Collections.Generic;
using System.Linq;

namespace _04.Count_Symbols
{
    using System;

    public class SymbolsCount
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!result.ContainsKey(letter))
                {
                    result.Add(letter, 0);
                }
                result[letter] += 1;
            }

            foreach (var letter in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}