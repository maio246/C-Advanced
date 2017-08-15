namespace _03.Squares_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SquareMatrix
    {
        public static void Main()
        {
            var matrixDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[][] charMatrix = new char[matrixDimentions[0]][];

            FillMatrix(matrixDimentions, charMatrix);

            var counter = 0;

            for (int row = 0; row < charMatrix.Length - 1; row++)
            {
                for (int col = 0; col < charMatrix[row].Length - 1; col++)
                {
                    var firstChar = charMatrix[row][col];
                    var secondChar = charMatrix[row][col + 1];
                    var thirdChar = charMatrix[row + 1][col];
                    var fourthChar = charMatrix[row + 1][col + 1];

                    if (firstChar == secondChar && thirdChar == fourthChar && firstChar ==  fourthChar)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static void FillMatrix(int[] matrixDimentions, char[][] charMatrix)
        {
            for (int row = 0; row < matrixDimentions[0]; row++)
            {
                charMatrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }
        }
    }
}
