namespace _05.Applied_Arithmetics
{
    using System;
    using System.Linq;

    public static class AppArythm
    {
        public static void Main()
        {
            var numbs = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var commandParams = Console.ReadLine();

            while (commandParams != "end")
            {
                switch (commandParams)
                {
                    case "add":
                        numbs = numbs.Select(n => n += 1).ToList();
                        break;
                    case "subtract":
                        numbs = numbs.Select(n => n -= 1).ToList();
                        break;
                    case "multiply":
                        numbs = numbs.Select(n => n *= 2).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbs));
                        break;
                }

                commandParams = Console.ReadLine();
            }
        }

    }
}
