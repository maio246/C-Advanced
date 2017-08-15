namespace _05.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;

    public static class EmailDom
    {
        public static void Main()
        {
            var student = Console.ReadLine();
            var result = new List<string[]>();
            while (student != "END")
            {
                if (student.Contains("@gmail.com"))
                {
                    result.Add(student.Split());
                }
                student = Console.ReadLine();
            }

            result.ForEach(std => Console.WriteLine($"{std[0]} {std[1]}"));
        }
    }
}
