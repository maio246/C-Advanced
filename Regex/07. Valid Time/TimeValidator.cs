namespace _07.Valid_Time
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public static class TimeValidator
    {
        public static void Main()
        {
            var digits = new Regex(@"^\d{2}:\d{2}:\d{2} ([AM]+|[PM]+)$");
            var result = new List<string>();

            var timeLine = Console.ReadLine();

            while (timeLine != "END")
            {
                if (!digits.IsMatch(timeLine))
                {
                    result.Add("invalid");
                    timeLine = Console.ReadLine();
                    continue;
                }

                var tokens = timeLine.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var hours = int.Parse(tokens[0]);
                var minutes = int.Parse(tokens[1]);
                var seconds = int.Parse(tokens[2]);

                if (hours < 12 && minutes <= 59 && seconds <= 59)
                {
                    result.Add("valid");
                }
                else if (hours == 12 && minutes <= 59 && seconds <= 59 && tokens[3] == "AM")
                {
                    result.Add("valid");
                }
                else
                {
                    result.Add("invalid");
                }

                timeLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", result));
        }

    }
}
