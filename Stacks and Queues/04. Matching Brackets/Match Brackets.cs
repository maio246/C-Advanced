namespace _04.Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var inputExpression = Console.ReadLine();
            
            var stack = new Stack<int>();

            for (int i = 0; i < inputExpression.Length; i++)
            {

                char ch = inputExpression[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    string content = inputExpression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(content);
                }
            }
        }
    }
}