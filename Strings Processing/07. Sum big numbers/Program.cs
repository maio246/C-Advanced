namespace _07.Sum_big_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Program
    {
        public static char[] numb2;
        public static char[] numb1;
        public static void Main()
        {
            numb2 = Console.ReadLine().Trim(new[] { '0' }).ToCharArray();
            numb1 = Console.ReadLine().Trim(new[] { '0' }).ToCharArray();

            var result = SumNumbs(numb2, numb1);

            Console.WriteLine(result);
        }

        public static int SumNumbs(char[] number2, char[] number1)
        {
            var diff = Math.Abs(number2.Length - number1.Length);
            var min = Math.Min(number2.Length, number1.Length);

            var tempRes = GetSum(number2, number1, min);

            if (diff != 0)
            {
                if (number2.Length > number1.Length)
                {
                    tempGetTailSum(number2, number1[0], diff)
                }
            }
            var tempTailRes = GetTailSum(diff);

            return tempRes;
        }
        public static int GetTailSum(int length)
        {
            var sum = 0;
            var firstnumb = int.Parse(numb1)
            if (numb2.Length > numb1.Length)
            {

            }
        }

        public static int GetSum(char[] number, char[] number1, int min)
        {
            var res = 0;
            for (int i = min; i >= 0; i--)
            {
                var numb1 = int.Parse(number[i].ToString());
                var numb2 = int.Parse(number1[i].ToString());

                res += (numb1 + numb2);
            }

            return res;
        }
    }
}
