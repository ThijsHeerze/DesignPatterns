using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private CdPlayer _cdPlayer;
        private DvdPlayer _dvdPlayer;
        private PopcornPopper _popcornPopper;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _theaterLights;
        private Tuner _tuner;

        public HomeTheaterFacade(
            Amplifier amplifier,
            CdPlayer cdPlayer,
            DvdPlayer dvdPlayer,
            PopcornPopper popcornPopper,
            Projector projector,
            Screen screen,
            TheaterLights theaterLights,
            Tuner tuner)
        {
            _amplifier = amplifier;
            _cdPlayer = cdPlayer;
            _dvdPlayer = dvdPlayer;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _theaterLights = theaterLights;
            _tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            System.Console.WriteLine("Get ready to watch a movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            System.Console.WriteLine("Shutting movie theater down...");
            _popcornPopper.Off();
            _theaterLights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
        }
    }
}
