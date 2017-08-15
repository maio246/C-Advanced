using System.Linq;

namespace _02.Simple_Calc
{
    using System;
    using System.Collections.Generic;
    public class Calculator
    {
        public static void Main()
        {
            var inputEquasion = Console.ReadLine().Split();
            
            var result = new Stack<string>(inputEquasion.Reverse());

            while (result.Count > 1)
            {
                var firstNumb = int.Parse(result.Pop());
                var operand = result.Pop();
                var secondNumb = int.Parse(result.Pop());

                switch (operand)
                {
                    case "+":
                        result.Push((firstNumb + secondNumb).ToString());
                        break;
                    case "-":
                        result.Push((firstNumb - secondNumb).ToString());
                        break;
                }
            }
            Console.WriteLine(result.Peek());
        }
    }
}