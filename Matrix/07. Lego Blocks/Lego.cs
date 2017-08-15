namespace _07.Lego_Blocks
{
    using System;
    using System.Linq;

    public class Lego
    {
        public static void Main()
        {
            var matricesRows = int.Parse(Console.ReadLine());

            if (matricesRows != 0)
            {

                int[][] firstLego = new int[matricesRows][];

                FillMatrix(matricesRows, firstLego);

                int[][] secondLego = new int[matricesRows][];

                FillMatrix(matricesRows, secondLego);

                bool isEqual = AreEqual(firstLego, secondLego);

                if (isEqual)
                {
                    PrintBlocks(firstLego, secondLego);
                }
                else
                {
                    var elements = 0;
                    for (int i = 0; i < firstLego.Length; i++)
                    {
                        elements += firstLego[i].Length;
                    }
                    for (int i = 0; i < secondLego.Length; i++)
                    {
                        elements += secondLego[i].Length;
                    }

                    Console.WriteLine($"The total number of cells is: {elements}");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: 0");

            }
        }

        public static void PrintBlocks(int[][] firstLego, int[][] secondLego)
        {
            foreach (var row in secondLego)
            {
                Array.Reverse(row);
            }

            var resultMatrix = new int[firstLego.Length][];

            for (int i = 0; i < firstLego.Length; i++)
            {

                var currentRow = firstLego[i].ToList();
                var rowToAdd = secondLego[i].ToList();

                currentRow.AddRange(rowToAdd);

                resultMatrix[i] = currentRow.ToArray();
            }

            foreach (var row in resultMatrix)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }
        }

        public static bool AreEqual(int[][] firstLego, int[][] secondLego)
        {
            var sum = firstLego[0].Length + secondLego[0].Length;

            var isEqual = false;

            for (int i = 1; i < firstLego.Length; i++)
            {
                var tempSum = firstLego[i].Length + secondLego[i].Length;

                if (sum == tempSum)
                {
                    isEqual = true;
                    break;
                }
                isEqual = false;
            }

            return isEqual;
        }

        public static void FillMatrix(int matricesRows, int[][] lego)
        {
            for (int i = 0; i < matricesRows; i++)
            {
                lego[i] = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
