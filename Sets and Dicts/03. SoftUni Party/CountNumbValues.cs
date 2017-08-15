using System;
using System.Collections.Generic;

public class CountNumbValues
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var result = new SortedDictionary<double, int>();

        foreach (var numb in inputLine)
        {
            var parsedNumb = double.Parse(numb);

            if (!result.ContainsKey(parsedNumb))
            {
                result.Add(parsedNumb, 0);
            }
            result[parsedNumb] += 1;
        }

        foreach (var numb in result)
        {
            Console.WriteLine($"{numb.Key} - {numb.Value} times");
        }
    }
}
