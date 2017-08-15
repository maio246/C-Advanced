namespace _02.Knights_Of_Honor
{
    using System;
    using System.Linq;

    public static class Knights
    {
        public static void Main()
        {
            var inputKnights = Console.ReadLine().Split().ToList();
            Action<string> printer = x => Console.WriteLine($"Sir {x}");

            inputKnights.ForEach(w => printer(w));
        }

    }
}
