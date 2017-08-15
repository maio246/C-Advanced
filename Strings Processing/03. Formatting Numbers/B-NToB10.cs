namespace _03.Formatting_Numbers
{
    using System;
    using System.Numerics;

    public static class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var numberToConvert = BigInteger.Parse(input[1]);
            var baseN = int.Parse(input[0]);

            var bin = new BigInteger(0);

            var numToString = numberToConvert.ToString();
            for (int i = 0; i < numToString.Length; i++)
            {
                var currentDigit = int.Parse(numToString[numToString.Length - 1 - i].ToString());
                var result = currentDigit * BigInteger.Pow(baseN, i);
                bin += result;
            }
            Console.WriteLine(bin);
        }
    }
}
