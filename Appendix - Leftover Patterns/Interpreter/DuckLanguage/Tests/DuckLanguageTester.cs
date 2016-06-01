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
        private Context context;
        private List<Expression> expressions;
        private Sequence sequence;

        public DuckLanguageTester()
        {
            expressions = new List<Expression>() { new Repetition(new FlyCommand()),
                                                   new Repetition(new QuackCommand()),
                                                   new Repetition(new RightCommand())};

            sequence = new Sequence(expressions);
            context = new Context(";", '(', ')');
        }


        public void Run(string input)
        {
            context = new Context(";", '(', ')');
            context.Input = input;
            sequence.Interpret(context);

            Console.WriteLine(context.Output);
        }
    }
}
