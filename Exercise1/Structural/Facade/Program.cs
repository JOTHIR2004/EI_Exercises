namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DVDPlayer dvd = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem sound = new SoundSystem();
            Lights lights = new Lights();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvd, projector, sound, lights);

            homeTheater.WatchMovie("Inception");
            homeTheater.EndMovie();

            Console.ReadKey();
        }
    }
}
