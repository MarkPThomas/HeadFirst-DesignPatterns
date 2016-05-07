using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater.Model
{
    public class Amplifier
    {
        public Tuner tuner{get; set;}
        public DvdPlayer dvdPlayer{get; set;}
        public CdPlayer cdPlayer{get; set;}

        public void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on.");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off.");
        }

        public void SetCD() { }

        public void SetDVD(DvdPlayer dvd)
        {
            Console.WriteLine("Top-O-Line Amplifier setting DVD player to {0}.", dvd);
        }

        public void SetStereoSound() { }

        public void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier surround sound on (5 speakers, 1 subwoofer).");
        }

        public void SetTuner() { }

        public void SetVolume(int level)
        {
            Console.WriteLine("Top-O-Line Amplifier setting volume to {0}.", level);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
