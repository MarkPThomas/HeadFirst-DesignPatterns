using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Repetition : Expression
    {
        private const string TIMES = "times";
        private const string WHILE = "while";
        private const string UNTIL = "until";

        private Variable _variable;
        private int _times; 
        private Expression _expression;

        public Repetition(Expression expression)
        {
            _expression = expression;
        }

        public override void Interpret(Context context)
        {
            _variable = new Variable();
            _variable.Interpret(context);

            string stream = context.Input;

            if (stream.Contains(TIMES) && int.TryParse(_variable.Value, out _times))
            {
                Times(context);
            }
            else if (stream.Contains(WHILE))
            {
                While(context);
            }
            else if (stream.Contains(UNTIL))
            {
                Until(context);
            }
            else
            {
                _expression.Interpret(context);
            }
        }

        // [command] (var) times; where var is an integer
        // [command].times(var); where var is an integer
        // (var).times(var);
        // (var) times (var); where vars are both integers

        private void Times(Context context)
        {
            for (int i = 0; i < _times; i++)
            {
                _expression.Interpret(context);
                if (!_expression.success) { break; }
            }
        }

        // while (var) [expression];  where var is a boolean
        // do while (var) [expression];  where var is a boolean
        // do [expression] while (var);  where var is a boolean

        private void While(Context context)
        {
            _expression.Interpret(context);
            if (_expression.success)
            {
                context.Output = string.Format("\nWhile {0} ... ", _variable.Value) + context.Output;
            }
        }


        // While with !var
        private void Until(Context context)
        {
            _expression.Interpret(context);
            if (_expression.success) { context.Output = string.Format("\nUntil {0} ... ", _variable.Value + context.Output); }
        }
    }
}
