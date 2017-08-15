using System.Text;

namespace _03.NMS
{
    using System;
    using System.Collections.Generic;

    public static class NMS
    {
        public static void Main()
        {
            var messages = new StringBuilder();
            string word;

            while ((word = Console.ReadLine()) != "---NMS SEND---")
            {
                messages.Append(word);
            }

            var delimiter = Console.ReadLine();
            var message = messages.ToString();

            var result = new StringBuilder();
            result.Append(message[0]);

            for (int i = 1; i < message.Length; i++)
            {
                var firstChar = message[i];
                var currChar = message[i - 1];

                if (string.Compare(firstChar.ToString(), currChar.ToString(), true) >= 0)
                {
                    result.Append(currChar);
                }
                else
                {
                    result.Append(delimiter);
                    result.Append(firstChar);
                }
            }

            Console.WriteLine(result);
        }
    }
}