namespace _02.Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;

    public static class Vowels
    {
        public static void Main()
        {
            var vowels = new Regex(@"[aeiouyAEIOUY]");

            var text = Console.ReadLine();

            var vowelsCount = vowels.Matches(text).Count;

            Console.WriteLine($"Vowels: {vowelsCount}");
        }
    }
}
