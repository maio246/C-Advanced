namespace _09.Crossfire
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class CrossFire
    {
        public static List<List<int>> targetField;

        public static void Main()
        {
            var matrixDimentions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            targetField = new List<List<int>>();

            targetField = FillShotField(matrixDimentions);

            ShootAtTarget(targetField);

            PrintField();
        }

        public static void ShootAtTarget(List<List<int>> targetField)
        {
            var shot = Console.ReadLine();

            while (shot != "Nuke it from orbit")
            {

                var shotParams = shot
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var shotRow = shotParams[0];
                var shotCol = shotParams[1];
                var range = shotParams[2];


                for (int rowIndex = shotRow - range;
                    rowIndex <= shotRow + range;
                    rowIndex++)
                {
                    if (IsInRange(rowIndex, shotCol))
                    {
                        targetField[rowIndex][shotCol] = -1;
                    } 
                }
                for (int colIndex = shotCol - range; 
                    colIndex <= shotCol + range;
                    colIndex++)
                {
                    if (IsInRange(shotRow, colIndex))
                    {
                        targetField[shotRow][colIndex] = -1;
                    }
                }
                RemoveFields();

                shot = Console.ReadLine();
            }
        }

        public static void RemoveFields()
        {
            for (int rowIndex = targetField.Count - 1; rowIndex >= 0; rowIndex--)
            {
                for (int colIndex = targetField[rowIndex].Count - 1; colIndex >= 0; colIndex--)
                {
                    if (targetField[rowIndex][colIndex] == -1)
                    {
                        targetField[rowIndex].RemoveAt(colIndex);
                    }
                }
                if (targetField[rowIndex].Count == 0)
                {
                    targetField.RemoveAt(rowIndex);
                }
            }
        }

        public static bool IsInRange(int shotRow, int shotCol)
        {
            if (shotRow >= 0 && shotRow < targetField.Count &&
                shotCol >= 0 && shotCol < targetField[shotRow].Count)
            {
                return true;
            }
            return false;
        }

        public static List<List<int>> FillShotField(int[] dimentions)
        {
            var field = new List<List<int>>();
            var counter = 1;
            for (int rowIndex = 0; rowIndex < dimentions[0]; rowIndex++)
            {
                field.Add(new List<int>());
                for (int colIndex = 0; colIndex < dimentions[1]; colIndex++)
                {
                    field[rowIndex].Add(counter);
                    counter++;
                }
            }
            return field;

        }

        public static void PrintField()
        {
            for (int rowIndex = 0; rowIndex < targetField.Count; rowIndex++)
            {
                Console.WriteLine(string.Join(" ", targetField[rowIndex]));
            }
        }

    }
}