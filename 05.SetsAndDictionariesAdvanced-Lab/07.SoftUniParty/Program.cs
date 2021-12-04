using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            HashSet<string> reservations = new HashSet<string>();

            while (input != "PARTY")
            {
                reservations.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (reservations.Contains(input))
                {
                    reservations.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count);

            foreach (var item in reservations)
            {
                char[] ch = item.ToCharArray();

                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in reservations)
            {
                char[] ch = item.ToCharArray();

                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}