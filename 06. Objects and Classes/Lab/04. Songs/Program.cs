using System;
using System.Collections.Generic;

namespace _04._Songs
{
    class Program
    {
        static void Main()
        {
            int numOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time
                };

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
