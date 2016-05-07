using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater.Model
{
    public class PopcornPopper
    {

        public void On()
        {
            Console.WriteLine("Popcorn Popper on.");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper off.");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
