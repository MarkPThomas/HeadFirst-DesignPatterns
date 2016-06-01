using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Variable : Expression
    {
        private char _openTag;
        private char _closeTag;

        public string Value { get; private set; }

        public override void Interpret(Context context)
        {
            string stream = context.Input.ToLower();
            _openTag = context.OpenTag;
            _closeTag = context.CloseTag;

            // Check if parentheses are not balanced
            if (_closeTag != ' ')
            {
                int numberOfVariables = stream.Split(_openTag).Length - 1;
                if (numberOfVariables != stream.Split(_closeTag).Length - 1) { return; }
            }
            

            Value = "";
            int startVariable = 0;
            int endVariable = 0;
            for (int i = 0; i < stream.Length; i++)
            {
                if (stream[i] == _openTag) { startVariable = i + 1; }
                if (stream[i] == _closeTag) { endVariable = i; }
            }
            Value = stream.Substring(startVariable, endVariable - startVariable);
            Value = Value.Trim();
        }
    }
}
