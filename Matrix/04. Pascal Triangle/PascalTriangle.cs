namespace _04.Pascal_Triangle
{
    using System;
    using System.Collections.Generic;

    public class PascalTriangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(1);
            Console.WriteLine("{0} {0}", 1);

            var que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(1);

            var temp = new Queue<int>();

            for (int i = 2; i < n; i++)
            {
                var numb1 = que.Dequeue();
                var numb2 = que.Dequeue();

                for (int jIndex = 0; jIndex < temp.Count; jIndex++)
                {
                    
                }
                temp.Enqueue(1);
                temp.Enqueue(numb1 + numb2);
            }
        }
    }
}
