namespace _04.Replace_tag
{
    using System;
    using System.Text.RegularExpressions;

    public static class ReplaceTag
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            while (text != "end")
            {

                var regex = new Regex(@"<a.*href.*?=(""|')(.*)\1>(.*)<\/a>");

                var result = regex
                    .Replace(text,
                        @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);

                text = Console.ReadLine();
            }
        }
    }
}
