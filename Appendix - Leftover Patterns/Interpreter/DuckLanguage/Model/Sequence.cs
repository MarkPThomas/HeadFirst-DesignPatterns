using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Sequence : Expression
    {
        private List<Expression> Expressions = new List<Expression>();

        public string Demarcator { get; private set; }

        public Sequence(string demarcator)
        {
            Demarcator = demarcator;
            Expressions.Add(new Repetition());
            Expressions.Add(new FlyCommand());
            Expressions.Add(new QuackCommand());
            Expressions.Add(new RightCommand());
        }
        public override void Interpret(Context context)
        {
            char[] input = context.Input.ToCharArray();
            string word = "";
            string demarcator = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (Demarcator.StartsWith(input[i].ToString()))
                {
                    for (int j = 0; j < Demarcator.Length; j++)
                    {
                        if (true)
                        {

                        }
                    }
                }
            }

        }
    }
}
