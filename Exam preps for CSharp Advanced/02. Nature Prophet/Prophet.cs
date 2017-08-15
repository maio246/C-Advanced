namespace _02.Nature_Prophet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Prophet
    {
        public static int[][] garden;

        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            garden = new int[dimentions[0]][];

            Fillgarden(dimentions);

            string curentFlower;

            while ((curentFlower = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                var flowerParams = curentFlower.Split().Select(int.Parse).ToArray();
                var row = flowerParams[0];
                var col = flowerParams[1];

                if (row < 0 && row > dimentions[0] && col < 0 && col > dimentions[1])
                {
                    break;
                }
                BloomGarden(row, col);
            }

            PrintGarden();

        }

        private static void PrintGarden()
        {
            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        public static void BloomGarden(int rowIndex, int colIndex)
        {
            for (int row = 0; row < garden.Length; row++)
            {
                if (row != rowIndex)
                {
                    garden[row][colIndex] += 1;
                }
            }

            for (int col = 0; col < garden[rowIndex].Length; col++)
            {
                if (col != colIndex)
                    garden[rowIndex][col] += 1;
            }

            garden[rowIndex][colIndex] += 1;
        }

        public static void Fillgarden(int[] dimentions)
        {
            for (int i = 0; i < garden.Length; i++)
            {
                garden[i] = new int[dimentions[1]];

                for (int j = 0; j < garden[i].Length; j++)
                {
                    garden[i][j] = 0;
                }
            }
        }
    }
}
