namespace _05.Rubiks_Matrix
{
    using System;
    using System.Linq;

    public static class Rubiks
    {
        public static long[][] rubik;

        public static void Main()
        {
            var matrixDimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            rubik = new long[matrixDimentions[0]][];

            FillRubiks(matrixDimentions, rubik);

            var commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                ShuffleMatrix(tokens, matrixDimentions);
            }

            RearangeMatrix();
        }

        private static void RearangeMatrix()
        {
            var numb = 1;
            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < rubik[rowIndex].Length; colIndex++)
                {
                    var numbToCompare = rubik[rowIndex][colIndex];

                    if (numbToCompare == numb)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < rubik.Length; r++)
                        {
                            for (int c = 0; c < rubik[0].Length; c++)
                            {
                                if (rubik[r][c] == numb)
                                {
                                    var currentElem = rubik[rowIndex][colIndex];
                                    rubik[rowIndex][colIndex] = numb;
                                    rubik[r][c] = currentElem;
                                    Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({r}, {c})");
                                    break;

                                }
                            }
                        }
                    }
                    numb++;
                }
            }

        }

        public static void ShuffleMatrix(string[] tokens, long[] dimentions)
        {
            var index = long.Parse(tokens[0]);
            var direction = tokens[1];
            var moves = long.Parse(tokens[2]);

            var currentNum = rubik[index][index];
            var numbToReplace = 0;
            switch (direction)
            {
                case "up":
                    MoveColumn(index, moves);
                    break;
                case "down":
                    MoveColumn(index, rubik.Length - moves);
                    break;
                case "left":
                    MoveRow(index, moves);
                    break;
                case "right":
                    MoveRow(index, rubik.Length - moves);
                    break;
            }
        }

        public static void MoveRow(long index, long moves)
        {
            var temp = new long[rubik[1].Length];

            for (int colIndex = 0; colIndex < temp.Length; colIndex++)
            {
                temp[colIndex] = rubik[index][(colIndex + moves) % temp.Length];
            }
            rubik[index] = temp;
        }

        public static void MoveColumn(long index, long moves)
        {
            var temp = new long[rubik.Length];

            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                temp[rowIndex] = rubik[(rowIndex + moves) % rubik.Length][index];
            }

            for (int i = 0; i < rubik.Length; i++)
            {
                rubik[i][index] = temp[i];
            }
        }

        public static void FillRubiks(long[] dimentions, long[][] rubik)
        {
            var counter = 1;
            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                rubik[rowIndex] = new long[dimentions[1]];

                for (int colIndex = 0; colIndex < dimentions[1]; colIndex++)
                {
                    rubik[rowIndex][colIndex] = counter;
                    counter++;
                }
            }
        }
    }
}
