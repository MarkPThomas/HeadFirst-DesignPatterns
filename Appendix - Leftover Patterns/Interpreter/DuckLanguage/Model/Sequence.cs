using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class Sequence : Expression
    {
        private string _demarcator;

        public List<Expression> Expressions { get; private set; } = new List<Expression>();

        public Sequence(List<Expression> expressions)
        {
            Expressions = expressions;
        }
        public override void Interpret(Context context)
        {
            _demarcator = context.Demarcator;
            context = SplitSequences(context);
            Execute(context);
        }

        private Context SplitSequences(Context context)
        {
            string stream = context.Input;
            
            int expressionLength = 0;
            for (int i = 0; i < stream.Length; i++)
            {
                if (_demarcator.StartsWith(stream[i].ToString()))
                {
                    string testDemarcator = stream.Substring(i, _demarcator.Length);
                    if (_demarcator == testDemarcator)
                    {
                        Context sequence = (Context)context.Clone();
                        sequence.Input = stream.Substring(i - expressionLength, expressionLength);
                        context.Sequences.Add(sequence);
                        expressionLength = 0;
                    }
                }
                else
                {
                    expressionLength++;
                }
            }
            return context;
        }

        private void Execute(Context context)
        {
            foreach (Context contextItem in context.Sequences)
            {
                foreach (Expression expression in Expressions)
                {
                    expression.Interpret(contextItem);
                }
            }
        }
    }
}
