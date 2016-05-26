using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    public class Goose 
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
