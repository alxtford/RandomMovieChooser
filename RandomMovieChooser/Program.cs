using System;
using System.IO;

namespace RandomMovieChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.randomMovieChooser();

            prog.chooseAgain();
        }

        void randomMovieChooser()
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

        void closeProgram()
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    // This was for testing the key listening capabilities.

                    //Console.WriteLine("Waiting");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            {
                randomMovieChooser();
            }
        }

        void chooseAgain()
        {

            Program prog = new Program();

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
                prog.randomMovieChooser();
            }
            chooseAgain();
        }
    }
}
