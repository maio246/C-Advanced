namespace _04.Int_Numbs
{
    using System;
    using System.Text.RegularExpressions;

    public static class IntNumbs
    {
        public static void Main()
        {
            var numubs = new Regex(@"\d+");
            var text = Console.ReadLine();

            var numbMatches = numubs.Matches(text);

            foreach (Match numbMatch in numbMatches)
            {
                Console.WriteLine(numbMatch.Value);
            }
        }
    }
}
