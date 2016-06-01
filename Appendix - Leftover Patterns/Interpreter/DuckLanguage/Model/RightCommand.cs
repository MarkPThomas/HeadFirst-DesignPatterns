using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class RightCommand : Expression
    {
        private List<string> _keywords = new List<string>();

        public RightCommand()
        {
            _keywords = new List<string>() { "right" };
        }

        public override void Interpret(Context context)
        {
            success = false;
            foreach (string keyword in _keywords)
            {
                if (context.Input.ToLower().Contains(keyword))
                {
                    context.Output += "\nThe duck turns right ...";
                    success = true;
                    return;
                }
            }
        }
    }
}
