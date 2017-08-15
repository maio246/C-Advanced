namespace _04.Basic_Que_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Queue_Basic
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersToPush = inputNumbers[0];
            var numbersToPop = inputNumbers[1];
            var elementToCheck = inputNumbers[2];

            var numbersToStack = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                numbers.Enqueue(numbersToStack[i]);
            }

            for (int index = 0; index < numbersToPop; index++)
            {
                numbers.Dequeue();
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