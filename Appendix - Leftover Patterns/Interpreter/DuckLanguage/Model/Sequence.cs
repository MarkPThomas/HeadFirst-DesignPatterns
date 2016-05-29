using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Sequence : Expression
    {
        private List<Expression> _expressions = new List<Expression>();
        public override void Interpret(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
