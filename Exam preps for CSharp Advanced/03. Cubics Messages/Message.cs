namespace _03.Cubics_Messages
{
    using System;
    using System.Text.RegularExpressions;

   public static class Message
    {
        public static void Main()
        {
            string currMsg;

            while ((currMsg = Console.ReadLine()) != "Over!")
            { 
                var number = int.Parse(Console.ReadLine());

                var validRgx = new Regex(@"^([\d]{0, " + number + @"})([\w]+)([^a-zA-Z\n]+)$");

                if (validRgx.IsMatch(currMsg))
                {
                    Console.WriteLine(validRgx.Match(currMsg).Value);
                }
            }
        }
    }
}
