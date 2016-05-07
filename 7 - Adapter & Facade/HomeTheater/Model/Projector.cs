using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater.Model
{
    public class Projector
    {
        public DvdPlayer dvdPlayer { get; set; }

        public void On()
        {
            Console.WriteLine("Top-O-Line Projector on.");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Projector off.");
        }

        public void SetInput(DvdPlayer dvd) { }

        public void TVMode() { }

        public void WideScreenMode()
        {
            Console.WriteLine("Top-O-Line Projector in widescreen moed (16x9 aspect ratio).");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
