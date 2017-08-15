using System.Collections.Generic;
using System.Linq;

namespace _09.UserLogs
{
    using System;

    public class UserLogs
    {
        public static void Main()
        {
            var usersLogs = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var id = tokens[1];
                var user = tokens[5];

                if (!usersLogs.ContainsKey(user))
                {
                    usersLogs.Add(user, new Dictionary<string, int>());
                }
                if (!usersLogs[user].ContainsKey(id))
                {
                    usersLogs[user][id] = 0;
                }
                usersLogs[user][id] += 1;

                inputLine = Console.ReadLine();
            }
            foreach (var user in usersLogs.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}: ");

                var logIp = user.Value.Keys.ToArray();
                var logCount = user.Value.Values.ToArray();

                for (int i = 0; i < user.Value.Count - 1; i++)
                {
                        Console.Write($"{logIp[i].ToString()} => {logCount[i].ToString()}, ");
                }
                Console.Write($"{logIp.Last().ToString()} => {logCount.Last().ToString()}.");
                Console.WriteLine();
            }
        }
    }
}