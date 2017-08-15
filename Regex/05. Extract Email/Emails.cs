namespace _05.Extract_Email
{
    using System;
    using System.Text.RegularExpressions;

    public static class Emails
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var regex = new Regex(@"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z]+)+");

            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                var matchToString = match.ToString();

                if (
                    !(matchToString.StartsWith("-") || matchToString.StartsWith(".") || matchToString.StartsWith("_")
                      || matchToString.EndsWith("-") || matchToString.EndsWith(".") || matchToString.EndsWith("_")))
                {
                    Console.WriteLine(matchToString);
                }
            }
        }
    }
}
