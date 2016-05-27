using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Model
{
    public interface IPersonBean
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Interests { get; set; }
        int HotOrNot { get; set; }

        void Poke();

        string Post();
    }
}
