namespace _13.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class magic
    {
        static void Main()
        {
            var words = Console.ReadLine().Split();

            bool AreExchangeable = ExchangeableWords(words);

            if (AreExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool ExchangeableWords(string[] words)
        {
            var firstWord = words[0].ToLower();
            var secondWord = words[1].ToLower();

            var shortestWord = Math.Min(firstWord.Length, secondWord.Length);
            var longestWord = Math.Max(firstWord.Length, secondWord.Length);

            bool areExchangeable = true;

            var result = new Dictionary<char, char>();

            for (int i = 0; i < shortestWord; i++)
            {
                if (!result.ContainsKey(firstWord[i]))
                {
                    if (result.ContainsValue(secondWord[i]))
                    {
                        break;
                    }
                    else
                    {
                        result[firstWord[i]] = secondWord[i];
                    }
                }
                else
                {
                    if (result[firstWord[i]] != (secondWord[i]))
                    {
                        areExchangeable = false;
                        break;
                    }
                }
            }
            var tailString = "";

            if (firstWord.Length == longestWord)
            {
                tailString = firstWord.Substring(shortestWord);
            }
            else
            {
                tailString = secondWord.Substring(shortestWord);

            }
            for (int i = 0; i < tailString.Length; i++)
            {
                if (!result.Keys.Contains(tailString[i])
                    && !result.Values.Contains(tailString[i]))
                {
                    areExchangeable = false;
                    break;

                }

            }
            return areExchangeable;
        }
    }
}
