namespace _03.Series_of_Letters
{
    using System;
    using System.Text.RegularExpressions;

    public static class DistinctLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(Regex.Replace(input, "([A-Za-z])\\1+", "$1"));
        }
    }
}
