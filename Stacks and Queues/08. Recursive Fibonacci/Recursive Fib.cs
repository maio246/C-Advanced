namespace _08.Recursive_Fibonacci
{
    using System;

    public class Recursive_Fib
    {
        static long[] fib;

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            fib = new long[number];

            fib[0] = 1;

            if (number > 1) fib[1] = 1;

            Console.WriteLine(Fibonacci(number - 1));
        }

        public static long Fibonacci(int n)
        {
            if (fib[n] == 0)
                fib[n] = Fibonacci(n - 2) + Fibonacci(n - 1);

            return fib[n];
        }
    }
}