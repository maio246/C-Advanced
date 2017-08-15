namespace _03.NonDigit_Count
{
    using System;
    using System.Text.RegularExpressions;

    public static class Vowels
    {
        public static void Main()
        {
            var digits = new Regex(@"[\D]");

            var text = Console.ReadLine();

            var nonDigitsCount = digits.Matches(text).Count;

            Console.WriteLine($"Non-digits: {nonDigitsCount}");
        }
    }
}
