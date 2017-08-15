namespace _02.Max_Sum_of_innerMatrix
{
    using System;
    using System.Linq;

    public class SumInnerMatrix
    {
        public static int[][] matrix;

        public static void Main()
        {
            var matrixDimentions = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            matrix = new int[matrixDimentions[0]][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int[] indexes = CheckMaxSum(matrix);

            PrintResult(indexes);

        }

        private static void PrintResult(int[] indexes)
        {
            for (int rowIndex = indexes[0]; rowIndex <= indexes[0] + 1; rowIndex++)
            {
                for (int colIndex = indexes[1]; colIndex <= indexes[1] + 1; colIndex++)
                {
                    Console.Write(matrix[rowIndex][colIndex] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(indexes[2]);
        }

        public static int[] CheckMaxSum(int[][] matrix)
        {
            var indexes = new int[3];
            var sum = 0;
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = CheckSum(row, col);

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        indexes[0] = row;
                        indexes[1] = col;
                        indexes[2] = currentSum;
                    }

                }
            }

            return indexes;
        }

        public static int CheckSum(int row, int col)
        {
            var currSum = 0;
            for (int rowIndex = row; rowIndex <= row + 1; rowIndex++)
            {
                for (int colIndex = col; colIndex <= col + 1; colIndex++)
                {
                    currSum += matrix[rowIndex][colIndex];
                }
            }
            return currSum;
        }
    }
}
