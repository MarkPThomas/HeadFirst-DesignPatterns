using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Model
{
    public class PersonBean : IPersonBean
    {
        private int _ratingCount = 0;

        public string Gender { get; set; }
        
        private int _hotOrNot;
        public int HotOrNot
        {
            get
            {
                if (_ratingCount == 0)
                {
                    return 0;
                }
                else
                {
                    return (_hotOrNot / _ratingCount);
                }
            }

            set
            {
                _hotOrNot += value;
                _ratingCount++;
            }
        }

        public string Interests { get; set; }

        public string Name { get; set; }

        public string Post()
        {
            return "I'm feeling like a " + HotOrNot + " today!";
        }

        public void Poke()
        {
            Console.WriteLine("You just poked " + Name);
        }
    }
}
