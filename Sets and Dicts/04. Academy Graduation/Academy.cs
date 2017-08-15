using System.Collections.Generic;
using System.Linq;

namespace _04.Academy_Graduation
{
    using System;

    public class Academy
    {
        public static void Main()
        {
            var studentsNumber = int.Parse(Console.ReadLine());

            var students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < studentsNumber; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());   
                }

                students[name] = grades;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}