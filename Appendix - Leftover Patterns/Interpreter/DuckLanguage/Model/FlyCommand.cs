using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLanguage.Model
{
    public class FlyCommand : Expression
    {
        private List<string> _keywords;

        public FlyCommand()
        {
            _keywords = new List<string>() { "fly" };
        }


        public override void Interpret(Context context)
        {
            success = false;
            foreach (string keyword in _keywords)
            {
                if (context.Input.Contains(keyword))
                {
                    context.Output += "\nthe duck is flying! Flap flap flap ...";
                    success = true;
                    return;
                }
            }
        }
    }
}
