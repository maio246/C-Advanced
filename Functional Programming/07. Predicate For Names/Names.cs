namespace _07.Predicate_For_Names
{
    using System;

    public static class Names
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= number)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
