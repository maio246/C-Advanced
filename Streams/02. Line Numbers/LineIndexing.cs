namespace _02.Line_Numbers
{
    using System.IO;

    public static class LineIndexing
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("Text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    var currentLine = reader.ReadLine();
                    var counter = 1;
                    while (currentLine != null)
                    {
                        writer.WriteLine($"{counter}. {currentLine}");
                        counter++;
                        currentLine = reader.ReadLine();
                    }
                }
            }

        }
    }
}
