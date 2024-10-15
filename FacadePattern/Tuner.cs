using System;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;

        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off");
        }

        public void SetAM()
        {
            Console.WriteLine("Tuner set to AM mode");
        }

        public void SetFM()
        {
            Console.WriteLine("Tuner set to FM mode");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"Tuner frequency set to {frequency} MHz");
        }
    }
}
