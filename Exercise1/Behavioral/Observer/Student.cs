using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Student : IObserver
    {
        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received notification: {message}");
        }
    }
}
