using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            var songs = new Queue<string>(input);

            while (songs.Any())
            {
                var command = Console.ReadLine();

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    var newSong = command.Substring(4);

                    if (!songs.Contains(newSong))
                    {
                        songs.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            if (!songs.Any())
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
