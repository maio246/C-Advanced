namespace _06.Count_Substring_Occurrences
{
    using System;

    public static class SubstrOcurr
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var found = text.IndexOf(substring, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);

        }
    }
}
