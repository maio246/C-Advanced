namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "search")
            {
                var contact = input.Split('-').ToArray();

                if (!phonebook.ContainsKey(contact[0]))
                {
                    phonebook.Add(contact[0], string.Empty);
                }
                phonebook[contact[0]] = contact[1];

                input = Console.ReadLine();
            }

            var search = Console.ReadLine();

            while (search != "stop")
            {

                if (phonebook.ContainsKey(search))
                {
                    Console.WriteLine($"{search} -> {phonebook[search]}");
                }
                else
                {
                    Console.WriteLine($"Contact {search} does not exist.");
                }

                search = Console.ReadLine();
            }

        }
    }
}