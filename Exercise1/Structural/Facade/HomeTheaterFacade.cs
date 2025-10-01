using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private DVDPlayer dvd;
        private Projector projector;
        private SoundSystem sound;
        private Lights lights;

        public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound, Lights lights)
        {
            this.dvd = dvd;
            this.projector = projector;
            this.sound = sound;
            this.lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("\nGet ready to watch a movie...");
            lights.Dim();
            projector.On();
            sound.On();
            sound.SetVolume(10);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("\nShutting movie theater down...");
        }
    }
}
