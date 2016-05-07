using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater.Model
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Theater Screen going up.");
        }

        public void Down()
        {
            Console.WriteLine("Theater Screen going down.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
