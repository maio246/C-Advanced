namespace _03.Special_Words
{
    using System;
    using System.Collections.Generic;

    public static class SWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine().Split(new [] {'{','}','(',')','<','>',',','-','!','?',' '}, StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                
                result.Add(currWord, 0);

                for (int j = 0; j < text.Length; j++)
                {
                    var wordToCompare = text[j];

                    if (wordToCompare == currWord)
                    {
                        result[currWord] += 1;
                    }
                }
            }

            foreach (var wordCount in result)
            {
                Console.WriteLine($"{wordCount.Key} - {wordCount.Value}");
            }
        }
    }
}
