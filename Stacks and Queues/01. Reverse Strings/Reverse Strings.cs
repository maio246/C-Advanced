namespace _01.Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class Reverse_Strings
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reversedInput = new Stack<char>();

            foreach (char letter in input)
            {
                reversedInput.Push(letter);
            }

            Console.WriteLine(string.Join("", reversedInput));
        }
    }
}