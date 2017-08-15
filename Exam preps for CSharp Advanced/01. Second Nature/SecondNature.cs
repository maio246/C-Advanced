namespace _01.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SecondNature
    {
        public static void Main()
        {
            var flowers = new Stack<int>(Console.ReadLine().Split().Select(f => int.Parse(f)));
            var buckets = new Stack<int>(Console.ReadLine().Split().Select(b => int.Parse(b)));
            var secondNatureFlowers = new Queue<int>();

            var currFlower = 0;
            while (flowers.Count > 0 && buckets.Count > 0)
            {
                currFlower = flowers.Pop();
                var currBucket = buckets.Pop();

                while (buckets.Count > 0 && currFlower - buckets.Peek() > 0)
                {
                    currFlower -= buckets.Pop();
                }
                var remainingWater = 0;
                if (buckets.Count > 0)
                {
                    if (currFlower - buckets.Pop() < 0)
                    {
                        remainingWater = buckets.Pop() - currFlower;
                    }
                    if (currFlower - buckets.Peek() == 0)
                    {
                        secondNatureFlowers.Enqueue(currFlower);
                        buckets.Pop();
                    }
                    if (buckets.Count > 0)
                    {
                        buckets.Push(buckets.Pop() + remainingWater);
                    }
                    else if (remainingWater > 0)
                    {
                        buckets.Push(remainingWater);
                    }
                }
                if (currFlower > 0) flowers.Push(currFlower);
            }

            if (flowers.Count == 0)
            {
                Console.WriteLine(string.Join(" ", buckets));
            }
            else
                Console.WriteLine($"{currFlower} {string.Join(" ", flowers)}");
            if (secondNatureFlowers.Count > 0)
                Console.WriteLine(string.Join(" ", secondNatureFlowers));
            else Console.WriteLine("None");
        }
    }
}
