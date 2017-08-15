namespace _04.Sort_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Sort
    {
        public static void Main()
        {
            var student = Console.ReadLine();
            var result = new List<Student>();
            while (student != "END")
            {
                var tokens = student
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currStudent = new Student(tokens[0], tokens[1]);
                result.Add(currStudent);

                student = Console.ReadLine();
            }

            result.OrderBy(x => x.LastName)
                .ThenByDescending(x => x.FirstName)
                .Select( x => $"{x.FirstName} {x.LastName}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
        class Student
        {
            public Student(string firstName, string lastname)
            {
                this.FirstName = firstName;
                this.LastName = lastname;
            }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int PhoneNumber { get; set; }
        }

    }
}
