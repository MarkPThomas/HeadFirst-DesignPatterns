using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Repetition : Expression
    {
        private Variable _variable;
        private Expression _expression;

        public override void Interpret(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
