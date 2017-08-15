namespace _02.Match_Phone
{
    using System;
    using System.Text.RegularExpressions;

    public static class PhoneNumb
    {
        public static void Main()
        {
            var phoneRegex = new Regex(@"^(?: |\A)\+(?:359)( |-)2\1(\d{3})\1(\d{4})$");

            var phoneNumb = Console.ReadLine();

            while (phoneNumb != "end")
            {
                if (phoneRegex.IsMatch(phoneNumb))
                {
                    Console.WriteLine(phoneNumb);
                }

                phoneNumb = Console.ReadLine();
            }
        }
    }
}
