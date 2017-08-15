namespace _06.Math_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var players = Console.ReadLine().Split();
            var turns = int.Parse(Console.ReadLine());

            var result = new Queue<string>(players);

            for (int i = 1; i <= turns; i++)
            {
                if (result.Count == 1)
                {
                    break;
                }

                var player = result.Dequeue();

                if (isPrime(i))
                {
                    result.Enqueue(player);
                    Console.WriteLine($"Prime {player}");
                }
                if (!isPrime(i))
                {
                    Console.WriteLine($"Removed {player}");
                }
            }
            Console.WriteLine($"Last is {result.Peek()}");

        }

        public static bool isPrime(int n)
        {
            if (n % 2 <= 0)
            {
                return n == 2;
            }
            int power2 = 9;
            for (int divisor = 3; power2 <= n; divisor += 2)
            {
                if (n % divisor == 0)
                    return false;
                power2 += divisor * 4 + 4;
            }
            return true;
        }
    }
}