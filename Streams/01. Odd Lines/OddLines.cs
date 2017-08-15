using System.Diagnostics;

namespace _01.Odd_Lines
{
    using System;
    using System.IO;

    public static class OddLines
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("OddLines.txt"))
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    var currentLine = reader.ReadLine();
                    var counter = 0;
                    while (currentLine != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(currentLine);
                            
                        }

                        counter++;
                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
