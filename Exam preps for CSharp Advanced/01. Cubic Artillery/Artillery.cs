namespace _01.Cubic_Artillery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Artillery
    {
        public static void Main()
        {

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            
            var maxCapacity = int.Parse(Console.ReadLine());
            var currentCapacity = maxCapacity;

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = inputLine.Split();

                foreach (var token in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(token, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(token);
                    }
                    else
                    {
                        var isSaved = false;
                        
                        while (bunkers.Count > 1)
                        {
                            if (currentCapacity >= weapon)
                            {
                             
                                weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            var bunkerToRemove = bunkers.Dequeue();

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkerToRemove} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkerToRemove} -> {string.Join(", ", weapons)}");
                            }

                            weapons.Clear();
                            currentCapacity = maxCapacity;
                        }
                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (currentCapacity < weapon)
                                    currentCapacity += weapons.Dequeue();

                                    weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                            }
                        }
                    }
                }
            }

        }
    }
}
