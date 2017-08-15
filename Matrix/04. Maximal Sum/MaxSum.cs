namespace _04.Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaxSum
    {
        public static int[][] numbersMatrix;

        public static void Main()
        {
            var matrixDimentions = Console.ReadLine()
                .Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbersMatrix = new int[matrixDimentions[0]][];

            FilledMatrix(numbersMatrix);

            var sum = long.MinValue;
            var indexes = new int[2];

            for (int row = 0; row < numbersMatrix.Length - 2; row++)
            {
                for (int col = 0; col < numbersMatrix[row].Length - 2; col++)
                {
                    GetSum(row, col);

                    var currentSum = GetSum(row, col);

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        indexes[0] = row;
                        indexes[1] = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            PrintResult(indexes);
        }

        public static void PrintResult(int[] indexes)
        {
            for (int rowIndex = indexes[0]; rowIndex <= indexes[0] + 2; rowIndex++)
            {
                for (int colIndex = indexes[1]; colIndex <= indexes[1] + 2; colIndex++)
                {
                    Console.Write(numbersMatrix[rowIndex][colIndex] + " ");
                }
                Console.WriteLine();
            }
        }

        public static long GetSum(int row, int col)
        {
            long sum = 0;
            for (int rowIndex = row; rowIndex <= row + 2 ; rowIndex++)
            {
                for (int colIndex = col; colIndex <= col + 2; colIndex++)
                {
                    sum += numbersMatrix[rowIndex][colIndex];
                }

            }
            return sum;
        }

        public static void FilledMatrix(int[][] numbersMatrix)
        {
            for (int row = 0; row < numbersMatrix.Length; row++)
            {
                numbersMatrix[row] = Console.ReadLine()
                    .Split(new []{" "},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
