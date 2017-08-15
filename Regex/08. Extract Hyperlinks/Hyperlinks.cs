namespace _08.Extract_Hyperlinks
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class Hyperlinks
    {
        public static void Main()
        {
            var text = new StringBuilder();

            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                text.AppendLine(inputLine).Append(" ");
                inputLine = Console.ReadLine();
            }

            var matches = Regex.Matches(text.ToString(), 
                @"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>"
            );

            foreach (Match match in matches)
            {
                string candidate = match.Groups[1].ToString().Trim();

                if (candidate[0] == '"')
                {
                    Console.WriteLine(candidate.Split(new []{'"'},
                        StringSplitOptions.RemoveEmptyEntries)
                        .First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(candidate, @"\s+").First());
                }
            }
        }
    }
}
