using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeTheater.Model;

namespace HomeTheater.Tests
{
    public class HomeTheaterTestDrive
    {
        public static void Run()
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popper = new PopcornPopper();

            HomeTheaterFacade homeTheater =
                new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}
