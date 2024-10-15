using System;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD Player on");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player off");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"DVD Player playing \"{movie}\"");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player stopped");
        }
    }
}
