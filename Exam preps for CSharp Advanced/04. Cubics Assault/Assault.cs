namespace _04.Cubics_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Assault
    {
        public static void Main()
        {
            string inputLine;

            var result = new Dictionary<string, Dictionary<string, long>>();
            while ((inputLine = Console.ReadLine()) != "Count em all")
            {
                var meteorParams = inputLine
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var region = meteorParams[0];
                var meteor = meteorParams[1];
                var amount = long.Parse(meteorParams[2]);

                if (!result.ContainsKey(region))
                {
                    result.Add(region, new Dictionary<string, long>());
                }
                if (!result[region].ContainsKey("Black"))
                {
                    result[region].Add("Black", 0);
                }
                if (!result[region].ContainsKey("Red"))
                {
                    result[region].Add("Red", 0);
                }
                if (!result[region].ContainsKey("Green"))
                {
                    result[region].Add("Green", 0);
                }

                var count = long.Parse(meteorParams[2]);
                var diff = count % 1000000;
                if (diff > 0 && diff < 1000000)
                {
                    switch (meteorParams[1])
                    {
                        case "Black":
                            result[region]["Black"] += diff;
                            break;
                        case "Red":
                            result[region]["Black"] += diff;
                            break;
                        case "Green":
                            result[region]["Red"] += diff;
                            break;
                    }
                }
                else
                {
                    switch (meteorParams[1])
                    {
                        case "Black":
                            result[meteorParams[0]]["Black"] += 1;
                            break;
                        case "Red":
                            result[meteorParams[0]]["Black"] += 1;
                            break;
                        case "Green":
                            result[meteorParams[0]]["Red"] += 1;
                            break;
                    }
                }
            }
            var asd = result.OrderByDescending(x => x.Value.Values).ThenBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in asd)
            {
                Console.WriteLine(region.Key);
                foreach (var meteor in region.Value)
                {
                    Console.WriteLine($"-> {meteor.Key} : {meteor.Value}");
                }
            }
        }
    }
}
