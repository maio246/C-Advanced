namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public static class WordCounter
    {
        public static void Main()
        {
            Dictionary<string, int> wordsResult = new Dictionary<string, int>();

            var linesList = new List<string>();
            var wordsToCompare = new List<string>();

            using (StreamReader words = new StreamReader("words.txt"))
            {
                using (StreamReader text = new StreamReader("text.txt"))
                {
                    var currentWord = words.ReadLine();

                    while (currentWord != null)
                    {
                        wordsToCompare.Add(currentWord);
                        wordsResult.Add(currentWord, 0);
                        currentWord = words.ReadLine();
                    }

                    var line = text.ReadLine();

                    while (line != null)
                    {
                        linesList.Add(line);

                        line = text.ReadLine();
                    }

                    foreach (var word in wordsToCompare)
                    {
                        foreach (var currLine in linesList)
                        {
                            var lineTokens = currLine
                            .ToLower()
                            .Split(new char[] { '-', '?', '!', '.', ',', ' ' },
                            StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < lineTokens.Length; i++)
                            {
                                if (word == lineTokens[i])
                                {
                                    wordsResult[word] += 1;
                                }
                            }
                        }
                    }
                }
            }
            using (StreamWriter result = new StreamWriter("result.txt"))
            {
                foreach (var word in wordsResult.OrderByDescending(x => x.Value))
                {
                    result.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}


