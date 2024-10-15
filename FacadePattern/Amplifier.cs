﻿using System;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
            Console.WriteLine("Amplifier setting CD player");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier setting DVD player");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier stereo sound on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound on");
        }

        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
            Console.WriteLine("Amplifier setting tuner");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier volume set to {volume}");
        }
    }
}
