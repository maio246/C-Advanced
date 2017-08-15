namespace _03.Highest_Element
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Highest_Number
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());

            var stackedNumbers = new Stack<int>();

            var maxElements = new Stack<int>();

            var max = int.MinValue;

            for (int i = 0; i < inputLines; i++)
            {
                var currentInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (currentInput[0] == 1)
                {
                    stackedNumbers.Push(currentInput[1]);

                    if (max < currentInput[1])
                    {
                        max = currentInput[1];
                        maxElements.Push(max);
                    }
                }
                else if (currentInput[0] == 2)
                {
                    if (stackedNumbers.Pop() == max)
                    {
                        maxElements.Pop();
                        if (maxElements.Count > 0)
                        {
                            max = maxElements.Peek();
                        }
                        else
                        {
                            max = int.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxElements.Peek());
                }

            }
        }
    }
}