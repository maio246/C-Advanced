namespace _06.Target_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Target
    {
        public static void Main()
        {
            var matrixDimention = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[][] stairs = new char[matrixDimention[0]][];

            var snakeBody = Console.ReadLine().ToCharArray();

            FillStairs(snakeBody, stairs, matrixDimention);

            ShootAtStairs(stairs);

            GravityIsOnBaby(stairs);

            PrintStairs(stairs);

        }

        public static void GravityIsOnBaby(char[][] stairs)
        {
            for (int colIndex = 0; colIndex < stairs[0].Length; colIndex++)
            {
                var stairCol = new Stack<char>();

                for (int rowIndex = 0; rowIndex < stairs.Length; rowIndex++)
                {
                    var currChar = stairs[rowIndex][colIndex];

                    if (currChar != ' ')
                    {
                        stairCol.Push(currChar);
                        stairs[rowIndex][colIndex] = ' ';
                    }
                }

                for (int i = stairs.Length - 1; i >= 0; i--)
                {
                    if (stairCol.Count > 0)
                    {
                        stairs[i][colIndex] = stairCol.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        public static void ShootAtStairs(char[][] stairs)
        {
            var shootParams = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rowIndex = shootParams[0];
            var colIndex = shootParams[1];
            var shotRange = shootParams[2];

            if (shotRange == 0)
            {
                stairs[rowIndex][colIndex] = ' ';
                return;
            }
            else
            {
                for (int row = 0; row < stairs.Length; row++)
                {
                    for (int col = 0; col < stairs[row].Length; col++)
                    {
                        if (Math.Pow(row - rowIndex, 2) + Math.Pow(col - colIndex, 2) <= Math.Pow(shotRange, 2))
                        {
                            stairs[row][col] = ' ';
                        }
                    }

                }
            }
        }

        public static void PrintStairs(char[][] stairs)
        {
            for (int rowIndex = 0; rowIndex < stairs.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < stairs[rowIndex].Length; colIndex++)
                {
                    Console.Write(stairs[rowIndex][colIndex]);
                }
                Console.WriteLine();
            }
        }

        public static void FillStairs(char[] snakeBody, char[][] stairs, int[] dimentions)
        {
            var counter = 0;
            var currChar = new char();

            for (int row = stairs.Length - 1; row >= 0; row--)
            {

                stairs[row] = new char[dimentions[1]];

                if (row % 2 == 0)
                {
                    for (int col = stairs[row].Length - 1; col >= 0; col--)
                    {
                        if (counter == snakeBody.Length)
                        {
                            counter = 0;
                        }

                        currChar = snakeBody[counter];

                        stairs[row][col] = snakeBody[counter];

                        counter++;

                    }
                }
                else
                {
                    for (int col = 0; col < stairs[row].Length; col++)
                    {
                        if (counter == snakeBody.Length)
                        {
                            counter = 0;
                        }

                        currChar = snakeBody[counter];

                        stairs[row][col] = snakeBody[counter];
                        counter++;

                    }
                }
            }
        }

        public static void HasToResetCounter(int counter, char[] snakeBody)
        {
        }
    }
}
