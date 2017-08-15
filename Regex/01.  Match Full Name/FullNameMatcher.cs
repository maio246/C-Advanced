namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public static class FullNameMatcher
    {
        public static void Main()
        {
            var names = Console.ReadLine();

            while (names != "end")
            {
                var nameValidations = Regex.Matches(names, @"^(?:[A-Z][a-z]+)+ (?:[A-Z][a-z]+)+$");

                foreach (Match validName in nameValidations)
                {
                    Console.WriteLine(validName.Value);
                }

                names = Console.ReadLine();
            }
        }
    }
}
