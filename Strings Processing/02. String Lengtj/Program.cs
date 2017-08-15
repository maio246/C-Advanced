namespace _02.String_Length
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            if (text.Length >= 20)
            {
                Console.WriteLine(text.Substring(0, 20));
            }
            else if (text.Length < 20)
            {
                var diff = new string('*', 20 - text.Length);
                Console.WriteLine(text + diff);
            }
        }
    }
}
