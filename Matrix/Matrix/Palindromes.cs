namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Palindromes
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] palindromes = new int[dimentions[0]][];

            for (int row = 0; row < palindromes.Length; row++)
            {
                var colArray = new int[dimentions[1]];

                for (int col = 0; col < colArray.Length; col++)
                {
                    var currentChar = (int)('a' + row);
                    var nextChar = (char)(currentChar + col);
                    Console.Write($"{(char)currentChar}{nextChar}{(char)currentChar} ");
                }
                Console.WriteLine();
            }
        }
    }
}
