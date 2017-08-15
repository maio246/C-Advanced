namespace _02.Basic_Operation_s
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Basic_Operands
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersToPush = inputNumbers[0];
            var numbersToPop = inputNumbers[1];
            var elementToCheck = inputNumbers[2];

            var numbersToStack = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                numbers.Push(numbersToStack[i]);
            }

            for (int index = 0; index < numbersToPop; index++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

        }
    }
}