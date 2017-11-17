using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new String[] {"Hi","How Are You","Bye"};
            while (true)
            {
                Console.WriteLine("Welcome to singer!");
                var i = 0;
                foreach (var song in songs)
                {
                    Console.WriteLine($"Choose {i + 1} for the song {song}!");
                    i++;
                }
                Console.WriteLine("Type 'Quit' to quit the application.");
                var response = Console.ReadLine();
                if (response.ToLower() == "quit")
                    break;

                var songout = 0;
                if(!int.TryParse(response,out songout))
                {
                    Console.WriteLine("Invalid Input ,Try again");
                    continue;
                }

                songout--;
                var fileName = songs[songout]+".txt";
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found , Try again!");
                    continue;
                }
                var lines = File.ReadAllLines(fileName);
                Console.WriteLine("======================================");
                foreach (var line in lines)
                {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("======================================");
            }
        }
    }
}
