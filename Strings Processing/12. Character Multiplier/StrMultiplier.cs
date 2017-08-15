namespace _12.Character_Multiplier
{
    using System;

    public static class StrMultiplier
    {
        public static void Main()
        {
            var inputStrint = Console.ReadLine().Trim().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var firstWord = inputStrint[0];
            var secondWord = inputStrint[1];

            var sum = 0;

            if (firstWord.Length == secondWord.Length)
            {
                sum = GetSum(firstWord, secondWord, sum);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                sum = GetSumDiff(firstWord, secondWord, sum);
            }
            else
            {
                sum = GetSumDiff(secondWord, firstWord, sum);
            }

            Console.WriteLine(sum);
        }

        public static int GetSumDiff(string firstWord, string secondWord, int sum)
        {
            for (int i = 0; i < secondWord.Length; i++)
            {
                var char1 = (int)firstWord[i];
                var char2 = (int)secondWord[i];

                sum += (char1 * char2);
            }

            for (int i = secondWord.Length; i < firstWord.Length; i++)
            {
                var char1 = (int)firstWord[i];

                sum += char1;
            }
            return sum;
        }

        public static int GetSum(string firstWord, string secondWord, int sum)
        {
            for (int i = 0; i < firstWord.Length; i++)
            {
                var char1 = (int)firstWord[i];
                var char2 = (int)secondWord[i];

                sum += ((int)firstWord[i] * (int)secondWord[i]);
            }

            return sum;
        }
    }
}
