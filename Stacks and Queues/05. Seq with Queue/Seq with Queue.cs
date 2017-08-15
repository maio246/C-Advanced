namespace _05.Seq_with_Queue
{
    using System;
    using System.Collections.Generic;

    public class Seq_with_Queue
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());

            var sequenceNumbs = new Queue<long>();
            var result = new List<long>();

            sequenceNumbs.Enqueue(input);
            result.Add(input);

            while (result.Count <= 50)
            {

                var currentNum = sequenceNumbs.Dequeue();
                var firstNumb = currentNum + 1;
                var secondNumb = 2 * currentNum + 1;
                var thirdNumb = currentNum + 2;

                sequenceNumbs.Enqueue(firstNumb);
                sequenceNumbs.Enqueue(secondNumb);
                sequenceNumbs.Enqueue(thirdNumb);

                result.Add(firstNumb);
                result.Add(secondNumb);
                result.Add(thirdNumb);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}