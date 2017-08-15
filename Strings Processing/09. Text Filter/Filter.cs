namespace _09.Text_Filter
{
    using System;

    public static class Filter
    {
        public static void Main()
        {
            var wordsToFilter = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            for (int i = 0; i < wordsToFilter.Length; i++)
            {
                text = text.Replace(wordsToFilter[i], new string('*', wordsToFilter[i].Length));
            }
            Console.WriteLine(text);

        }
    }
}
