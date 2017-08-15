namespace _05.HotPotato
{
    using System;
    using System.Collections.Generic;

    public class Hot_Potato
    {
        public static void Main()
        {
            var players = Console.ReadLine().Split();
            var turns = int.Parse(Console.ReadLine());

            var result = new Queue<string>(players);

            while (result.Count > 1)
            {
                for (int i = 1; i <= turns; i++)
                {
                    var player = result.Dequeue();
                    if (i != turns)
                    {
                        result.Enqueue(player);
                    }
                    else
                    {
                        Console.WriteLine($"Removed {player}");
                    }
                }
            }
            Console.WriteLine($"Last is {result.Peek()}");
        }
    }
}