namespace _02._Diagonal_Difference
{
    using System;
    using System.Linq;

    public static class DiagonalDiff
    {
        public static void Main()
        {
            var matrixDimention = int.Parse(Console.ReadLine());

            int[][] numbersMatrix = new int[matrixDimention][];

            for (int row = 0; row < matrixDimention; row++)
            {
                numbersMatrix[row] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var firstNumbers = 0;
            var secondNumbers = 0;
            var position = numbersMatrix.Length - 1;

            for (int row = 0; row < numbersMatrix.Length; row++)
            {
                for (int col = 0; col < numbersMatrix.Length; col++)
                {
                    if (row == col)
                    {
                        firstNumbers += numbersMatrix[row][col];
                        if (position >= 0)
                        {
                            secondNumbers += numbersMatrix[row][position];
                            position--;
                        }
                        break;
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstNumbers - secondNumbers));
        }
    }
}
