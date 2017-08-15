namespace _06.Valid_Usernames
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public static class Usernames
    {
        public static void Main()
        {
            var namesValidator = new Regex(@"^[\w-]{3,16}$");
            var username = Console.ReadLine();
            var validNames = new List<string>();

            while (username != "END")
            {
                if (namesValidator.IsMatch(username))
                {
                    validNames.Add("valid");
                }
                else
                {
                    validNames.Add("invalid");
                }

                username = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", validNames));
        }
    }
}
