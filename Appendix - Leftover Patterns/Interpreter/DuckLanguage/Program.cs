using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DuckLanguage.Tests;

namespace DuckLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckLanguageTester duckTester = new DuckLanguageTester();

            // right;        // Turn duck right
            // while (daylight) fly;    // Fly all day
            // quack;   // and then quack
            duckTester.Run("right; while (daylight) fly; quack;");
            duckTester.Run("right; until (sunset) fly; quack;");
            duckTester.Run("right; fly (5) times; quack;");

            Console.WriteLine("\nUser input test ...");
            string QUIT_CODE = "exit";
            Console.WriteLine("Enter '{0}' to stop.", QUIT_CODE);
            bool inSession = true;
            string input;
            do
            {
                Console.Write("\nDefine Operation: ");
                input = Console.ReadLine();
                if (input != QUIT_CODE)
                {
                    duckTester.Run(input);
                }
                else
                {
                    inSession = false;
                }
            }
            while (inSession);

            Console.ReadKey();
        }
    }
}
