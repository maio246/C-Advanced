using System;

public class Program
{
    public static void Main()
    {
        var matrixDimentions = int.Parse(Console.ReadLine());

        char[][] chessBoard = new char[matrixDimentions][];

        FillChessBoard(matrixDimentions, chessBoard);

        int result = EliminateKnights(chessBoard);

        Console.WriteLine(result);
    }

    private static int EliminateKnights(char[][] chessBoard)
    {

        var result = 0;


        for (int row = 0; row < chessBoard.Length; row++)
        {
            for (int col = 0; col < chessBoard[row].Length; col++)
            {
                try
                {

                    var currChar = chessBoard[row][col];

                    if (currChar == 'K')
                    {
                        if (chessBoard[row - 3][col - 1] == 'K')
                        {
                            result++;
                            chessBoard[row - 3][col - 1] = 'O';
                        }

                        else if (chessBoard[row - 3][col + 1] == 'K')
                        {
                            result++;
                            chessBoard[row - 3][col + 1] = 'O';
                        }

                        else if (chessBoard[row + 3][col - 1] == 'K')
                        {
                            result++;
                            chessBoard[row - 3][col - 1] = 'O';
                        }

                        else if (chessBoard[row + 3][col + 1] == 'K')
                        {
                            result++;
                            chessBoard[row + 3][col + 1] = 'O';
                        }
//////////////////////////////////////////////////////////////
                        else if (chessBoard[row - 1][col - 3] == 'K')
                        {
                            result++;
                            chessBoard[row - 1][col - 3] = 'O';
                        }

                        else if (chessBoard[row - 1][col + 3] == 'K')
                        {
                            result++;
                            chessBoard[row - 1][col + 3] = 'O';
                        }

                        else if (chessBoard[row + 1][col - 3] == 'K')
                        {
                            result++;
                            chessBoard[row - 1][col + 3] = 'O';
                        }

                        else if (chessBoard[row + 1][col + 3] == 'K')
                        {
                            result++;
                            chessBoard[row + 1][col + 3] = 'O';
                        }

                    }

                }
                catch (Exception e)
                {

                }

            }
        }
        return result;
    }

    private static void FillChessBoard(int matrixDimentions, char[][] chessBoard)
        {
            for (int row = 0; row < chessBoard.Length; row++)
            {
                chessBoard[row] = new char[matrixDimentions];
                var inputLine = Console.ReadLine();

                for (int col = 0; col < matrixDimentions; col++)
                {
                    chessBoard[row][col] = inputLine[col];
                }
            }
        }
    }

