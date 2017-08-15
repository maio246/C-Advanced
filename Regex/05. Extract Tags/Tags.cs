using System.Collections.Generic;

namespace _05.Extract_Tags
{
    using System;
    using System.Text.RegularExpressions;

    public static class Tags
    {
        public static void Main()
        {
            var tags = new Regex(@"<.+?>");

            var text = Console.ReadLine();

            var tagsColl = new List<string>();
            
            while (text != "END")
            {
                var tempMatches = tags.Matches(text);

                foreach (Match tempMatch in tempMatches)
                {
                    tagsColl.Add(tempMatch.Value);
                }
                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", tagsColl));
        }
    }
}
