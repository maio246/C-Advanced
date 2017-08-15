namespace _01.Match_Count
{
    using System;
    using System.Text.RegularExpressions;

    public static class MatchCount
    {
        public static void Main()
        {
            var wordToMatch = new Regex(Console.ReadLine());

            var text = Console.ReadLine();

            var wordCount = wordToMatch.Matches(text).Count;

            Console.WriteLine(wordCount);
        }
    }
}
