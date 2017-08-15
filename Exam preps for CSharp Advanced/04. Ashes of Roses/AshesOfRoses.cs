    using System.Collections.Generic;
    using System.Linq;

    namespace _04.Ashes_of_Roses
    {
        using System.Text.RegularExpressions;
        using System;

        public static class AshesOfRoses
        {
            public static void Main()
            {
                var matchRgx = new Regex(@"^Grow <(?<region>[A-Z][a-z]+)> <(?<color>[a-zA-Z\d]+)> (?<amount>\d+)$");

                var roses = new Dictionary<string, Dictionary<string, long>>();

                string inputLine;

                while ((inputLine = Console.ReadLine()) != "Icarus, Ignite!")
                {
                    var matcher = matchRgx.Match(inputLine);

                    if (!matcher.Success)
                    {
                        continue;
                    }

                    var region = matcher.Groups["region"].Value;
                    var roseColor = matcher.Groups["color"].Value;
                    var amountOfRoses = long.Parse(matcher.Groups["amount"].Value);

                    if (!roses.ContainsKey(region))
                    {
                        roses.Add(region, new Dictionary<string, long>());
                    }
                    if (!roses[region].ContainsKey(roseColor))
                    {
                        roses[region].Add(roseColor, 0);
                    }
                    roses[region][roseColor] += amountOfRoses;
                }

                foreach (var region in roses
                    .OrderByDescending(x => x.Value.Values.Sum())
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine(region.Key);

                    foreach (var rose in region.Value
                        .OrderBy(x => x.Value)
                        .ThenBy(x => x.Key))
                        Console.WriteLine($"*--{rose.Key} | {rose.Value}");
                }
            }
        }
    }
