using System;

namespace FacadePattern
{
    internal class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Projector input set to DVD Player");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode");
        }
    }
}
