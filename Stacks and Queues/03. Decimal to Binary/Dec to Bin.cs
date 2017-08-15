using System.Collections.Generic;

namespace _03.Decimal_to_Binary
{
    using System;

    public class Dec_to_Bin
    {
        public static void Main()
        {
            var decimalNumb = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (decimalNumb == 0) Console.WriteLine(0);
            else
            {
                while (decimalNumb != 0)
                {
                    stack.Push(decimalNumb % 2);
                    decimalNumb /= 2;
                }
                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop());
                }
            }
            Console.WriteLine();
        }
    }
}