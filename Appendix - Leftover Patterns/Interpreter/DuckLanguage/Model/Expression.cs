using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public abstract class Expression
    {
        public bool success { get; protected set; }

        public abstract void Interpret(Context context);
    }
}
