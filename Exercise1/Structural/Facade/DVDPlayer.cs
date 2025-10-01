using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player On");
        public void Play(string movie) => Console.WriteLine($"Playing {movie}");
    }
}
