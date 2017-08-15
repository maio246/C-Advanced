namespace _04.Concat_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Concat
    {
        public static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());

            var text = new StringBuilder();

            for (int i = 0; i < wordsCount; i++)
            {
                text.Append(Console.ReadLine() + " ");
            }

            Console.WriteLine(text);
        }
    }
}
