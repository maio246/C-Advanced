namespace _03.Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public static class Uppercased
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> UpperCased = c => char.IsUpper(c[0]);

            Console.WriteLine(string.Join("\n", text.Where(w => UpperCased(w)).ToList()));
        }
    }
}
