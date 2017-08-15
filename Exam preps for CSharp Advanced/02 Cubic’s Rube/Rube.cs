namespace _02_Cubic_s_Rube
{
    using System;
    using System.Linq;

    public static class Rube
    {
        public static void Main()
        {
            var dimentions = long.Parse(Console.ReadLine());

            long[,,] cubicsRube = new long[dimentions,dimentions, dimentions];

            for (int i = 0; i < dimentions; i++)
            {
                for (int j = 0; j < dimentions; j++)
                {
                    for (int k = 0; k < dimentions; k++)
                    {
                        cubicsRube[i,j,k] = 0;
                    }
                }
            }

            string pointParams;

            while ((pointParams = Console.ReadLine()) != "Analyze")
            {
                var tokens = pointParams
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                var point = tokens.Take(3);
                var particles = tokens.Last();

                if (point.All(n => n >= 0 && n <= dimentions))
                {
                    cubicsRube[tokens[0], tokens[1], tokens[2]] = particles;
                }
            }

            long sum = 0;
            long cells = 0;

            for (int i = 0; i < dimentions; i++)
            {
                for (int j = 0; j < dimentions; j++)
                {
                    for (int k = 0; k < dimentions; k++)
                    {
                        if (cubicsRube[i, j, k] != 0)
                            sum += cubicsRube[i, j, k];
                        else
                        cells++;
                    }
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(cells);
        }
    }
}
