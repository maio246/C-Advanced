namespace _02.Parse_URLs
{
    using System;

    public static class ParseUrls
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var openTag = "<upcase>";
            var closingTag = "</upcase>";

            var startingIndex = inputText.IndexOf(openTag);
            while (startingIndex != -1)
            {
                var endIndex = inputText.IndexOf(closingTag);

                if (endIndex == -1)
                {
                    break;
                }

                var subStrToReplace = inputText.Substring(startingIndex, endIndex + closingTag.Length - startingIndex);
                var replacedText = subStrToReplace.Replace(openTag, String.Empty).Replace(closingTag, String.Empty).ToUpper();

                inputText = inputText.Replace(subStrToReplace, replacedText);

                startingIndex = inputText.IndexOf(openTag);
            }

            Console.WriteLine(inputText);
        }
    }
}
