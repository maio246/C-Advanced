namespace _01.Sum_Elements
{
    using System;
    using System.Linq;

    public static class SumElements
    {
        public static void Main()
        {
            var matrixDimentions = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[matrixDimentions[0]][];

            var sum = 0;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => sum += int.Parse(n))
                    .ToArray();
            }
            Console.WriteLine(matrixDimentions[0]);
            Console.WriteLine(matrixDimentions[1]);
            Console.WriteLine(sum);
        }
    }
}
