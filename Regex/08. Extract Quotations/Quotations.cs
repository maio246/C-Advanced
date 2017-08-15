namespace _08.Extract_Quotations
{
    using System;
    using System.Text.RegularExpressions;

    public static class Program
    {
        public static void Main()
        {
            var quotationsReg = new Regex("(\"|')(.*?)\\1");

            var result = quotationsReg.Matches(Console.ReadLine());

            foreach (Match quote in result)
            {
                Console.WriteLine(quote.Groups[2].Value);
            }
        }
    }
}
