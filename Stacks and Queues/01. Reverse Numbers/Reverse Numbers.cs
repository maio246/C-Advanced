namespace _01.Reverse_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Reverse_Numbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numbers = new Stack<int>();

            foreach (var number in input)
            {
                numbers.Push(number);
            }

            foreach (var number in numbers.ToArray())
            {
                Console.Write($"{numbers.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}