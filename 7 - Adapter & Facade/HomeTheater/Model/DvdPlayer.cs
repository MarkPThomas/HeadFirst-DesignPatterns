using System;

namespace HomeTheater.Model
{
    public class DvdPlayer
    {
        Amplifier _amplifier;

        string _movie;

        public void On()
        {
            Console.WriteLine("Top-O-Line DVD Player on.");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line DVD Player off.");
        }

        public void Eject()
        {
            Console.WriteLine("Top-O-Line DVD Player eject.");
        }

        public void Pause() { }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine("Top-O-Line DVD Player playing \"{0}\".", _movie);
        }

        public void Stop()
        {
            Console.WriteLine("Top-O-Line DVD Player stopped \"{0}\".", _movie);
        }

        public void SetSurroundSoundAudio() { }

        public void SetTwoChannelAudio() { }

        public override string ToString()
        {
            return "Top-O-Line DVD Player";
        }
    }
}