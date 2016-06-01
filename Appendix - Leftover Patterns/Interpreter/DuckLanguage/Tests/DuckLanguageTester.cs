using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DuckLanguage.Model;

namespace DuckLanguage.Tests
{
    public class DuckLanguageTester
    {
        public static void Run()
        {
            // right;        // Turn duck right
            // while (daylight) fly;    // Fly all day
            // quack;   // and then quack


            // Take input stream
            string input = "";

            // Parse into list of words
            Context context = new Context();
            context.Input = input;

            Sequence sequence = new Sequence(";");
            sequence.Interpret(context);
                

            // Run through iteration of expressions for matches & actions



        }
    }
}
