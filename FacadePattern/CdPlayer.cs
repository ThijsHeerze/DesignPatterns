using System;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;

        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CD Player on");
        }

        public void Off()
        {
            Console.WriteLine("CD Player off");
        }

        public void Eject()
        {
            Console.WriteLine("CD Player ejecting CD");
        }

        public void Pause()
        {
            Console.WriteLine("CD Player paused");
        }

        public void Play()
        {
            Console.WriteLine("CD Player playing");
        }

        public void Stop()
        {
            Console.WriteLine("CD Player stopped");
        }
    }
}
