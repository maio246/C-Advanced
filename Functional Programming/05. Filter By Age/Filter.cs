using System.Linq;
using System.Runtime.InteropServices;

namespace _05.Filter_By_Age
{
    using System;
    using System.Collections.Generic;

    public static class Filter
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPerson = Console.ReadLine()
                    .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);

                people.Add(currentPerson[0], int.Parse(currentPerson[1]));
            }

            var condition = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Action<KeyValuePair<string, int>> formatFunc = GetFormatType(format);
            Func<int, bool> conditionFunc = PrintOthers(condition, years);

            PrintTotal(people, formatFunc, conditionFunc);
        }

        public static void PrintTotal(
            Dictionary<string, int> people, 
            Action<KeyValuePair<string, int>> formatFunc, 
            Func<int, bool> conditionFunc)
        {
            foreach (var person in people)
            {
                if (conditionFunc(person.Value))
                {
                    formatFunc(person);
                }
            }
        }

        public static Func<int, bool> PrintOthers(string condition, int years)
        {
            if (condition == "older")
            {
                return n => n >= years;
            }
            else
            {
                return n => n < years;
            }
        }

        public static Action<KeyValuePair<string, int>> GetFormatType(string format)
        {
            switch (format)
            {
                case "name age":
                    return f => Console.WriteLine($"{f.Key} - {f.Value}");
                case "age":
                    return f => Console.WriteLine($"{f.Value}");
                case "name":
                    return f => Console.WriteLine($"{f.Key}");
                default:
                    return null;
            }
        }
    }
}
