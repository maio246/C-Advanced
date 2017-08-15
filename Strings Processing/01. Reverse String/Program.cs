namespace _01.Reverse_String
{
    using System.Text;
    using System;
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            var stringToReverse = Console.ReadLine();

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                Console.Write(stringToReverse[i]);
            }
            Console.WriteLine();
        }
    }
}
