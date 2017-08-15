namespace _01.Students_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsResults
    {
        public static void Main()
        {
            var results = new Dictionary<string, double[]>();

            var studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                var studentTokens = Console.ReadLine()
                    .Split(new[] { "- " }, StringSplitOptions.RemoveEmptyEntries);

                var student = studentTokens[0];
                var grades = studentTokens[1]
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();

                if (!results.ContainsKey(student))
                {
                    results.Add(student, new double[3]);
                }
                results[student] = grades;
            }

            Console.WriteLine(string.Format($"{"Name", -10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|"));
            foreach (var student in results)
            {
                var average = student.Value.Average();
                Console.WriteLine(string.Format($"{student.Key, -10}|{student.Value[0],7:f2}|{student.Value[1],7:f2}|{student.Value[2],7:f2}|{average,7:f4}|"));
            }
        }
    }
}
