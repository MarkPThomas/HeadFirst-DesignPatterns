using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class QuackCommand : Expression
    {
        private List<string> _keywords = new List<string>();

        public QuackCommand()
        {
            _keywords = new List<string>() { "quack" };
        }

        public override void Interpret(Context context)
        {
            success = false;
            foreach (string keyword in _keywords)
            {
                if (context.Input.Contains(keyword))
                {
                    context.Output += "\nQuack! Quack! Quack! Quack!";
                    success = true;
                    return;
                }
            }
        }
    }
}
