namespace _07.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public static class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine().Split(new[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\b[a-zA-Z][\w_]{2,25}\b");

            var matches = new List<string>();

            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    matches.Add(username);
                }
            }
            var couples = new List<string>();

            var biggestSum = 0;

            for (int i = 1; i < matches.Count; i++)
            {
                var firstMatch = matches[i - 1];
                var secondMatch = matches[i];

                var currentSum = firstMatch.Length + secondMatch.Length;

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    couples.Clear();
                    couples.Add(firstMatch);
                    couples.Add(secondMatch);
                }
            }

            foreach (var username in couples)
            {
                Console.WriteLine(username);
            }
        }
    }
}
