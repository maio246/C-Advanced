namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Palindromes
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var halfLength = input[i].Length + 1 / 2;

                var leftHalfString = input[i].Substring(0, halfLength);

                var reversed = input[i].ToCharArray();

                Array.Reverse(reversed);

                var reversedString = new string(reversed);

                var reversedInput = reversedString.Substring(0, halfLength);

                if (reversedInput == leftHalfString)
                {
                    result.Add(input[i]);
                }
            }

            result = result.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
}
