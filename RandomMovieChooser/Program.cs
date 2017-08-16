using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace RandomMovieChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            randomMovieChooser();

            chooseAgain();
        }

        static void randomMovieChooser()
        {
            Random RNG = new Random();

            string[] file;

            file = File.ReadAllLines(Environment.CurrentDirectory + @"\Film List.txt");

            int filmID = 0;

            for (int i = 0; i < file.Length; i++)
            {
                filmID = i;
            }

            Console.WriteLine(file[RNG.Next(1, file.Length)]);

        }

        static void closeProgram()
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    //Console.WriteLine("Waiting");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            {
                randomMovieChooser();
            }
        }
        static void chooseAgain()
        {
            Console.WriteLine("If you'd like to choose again, press ENTER");

            do
            {
                while (!Console.KeyAvailable)
                {
                    //Console.WriteLine("Waiting");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            {
                randomMovieChooser();
            }

            chooseAgain();
        }
    }
}
