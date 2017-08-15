using System;
using System.Text.RegularExpressions;

namespace _06.Sentence_Extractor
{
    public static class SentenceExtractor
    {
        public static void Main()
        {
            var wordToMatch = Console.ReadLine();
            var text = Console.ReadLine();

            var sentenceMatch = new Regex("\\b" + wordToMatch + "\\b");
            var sentences = new Regex(@"[A-Z].+?[a-z]+(?:!|\?|\.)");

            var validSentences = sentences.Matches(text);

            foreach (Match validSentence in validSentences)
            {
                if (sentenceMatch.IsMatch(validSentence.Value))
                {
                    Console.WriteLine(validSentence.Value);
                }
            }
        }
    }
}
