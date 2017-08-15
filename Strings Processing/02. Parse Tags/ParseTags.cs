namespace _02.Parse_Tags
{
    using System;
    using System.Text.RegularExpressions;

    public static class ParseTags
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var protocol = @"://";
            var resourse = @"/";
            if (Regex.Matches(text, protocol).Count != 1 && Regex.Matches(text, resourse).Count != 3)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var protocolIndex = text.IndexOf(protocol);
                var protocolSubstr = text.Substring(0, protocolIndex);

                var tokens = text.Substring(protocolIndex + protocol.Length).Split('/');

                Console.WriteLine($"Protocol = {protocolSubstr}");

                Console.WriteLine($"Server = {tokens[0]}");

                Console.WriteLine($"Resources = {tokens[1]}/{tokens[2]}");
            }
        }
    }
}
