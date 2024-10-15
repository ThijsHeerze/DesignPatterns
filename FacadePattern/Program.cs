namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantieer subsystemen
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            // Maak de HomeTheaterFacade aan met alle subsystemen
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, cdPlayer, dvdPlayer, popcornPopper, projector, screen, lights, tuner);

            // Start de film met de versimpelde methodes
            homeTheater.WatchMovie("Die Hard");
            System.Console.WriteLine(); // Lege regel voor leesbaarheid

            // Stop de film met de versimpelde methodes
            homeTheater.EndMovie();
        }
    }
}
