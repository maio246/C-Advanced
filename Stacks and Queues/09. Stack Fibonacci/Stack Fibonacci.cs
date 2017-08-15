namespace _09.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Stack_Fibonacci
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new Stack<long>();

            result.Push(1);
            result.Push(1);


            for (int i = 0; i < n - 1; i++)
            {

                var x = result.Pop();
                var y = result.Pop();
                var z = x + y;

                result.Push(y);
                result.Push(x);
                result.Push(z);
            }
            Console.WriteLine(result.Peek());
        }
    }
}