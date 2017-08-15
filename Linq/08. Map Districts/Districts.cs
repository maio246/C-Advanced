using System.Security.Cryptography.X509Certificates;

namespace _08.Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Districts
    {
        public static void Main()
        {
            var inputCities = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var cities = new Dictionary<string, List<long>>();

            foreach (var inputCity in inputCities)
            {
                var tokens = inputCity.Split(new []{':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var city = tokens[0];
                var currPopulation = long.Parse(tokens[1]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<long>());
                }
                cities[city].Add(currPopulation);
            }
            var population = long.Parse(Console.ReadLine());

            var result = cities
                .Where(x => x.Value.Sum() > population);

            foreach (var district in result.OrderByDescending(x => x.Key).ThenByDescending(x => x.Value))
            {
                Console.WriteLine($"{district.Key}: {string.Join(" ", district.Value)}");
            }


        }
    }
}
