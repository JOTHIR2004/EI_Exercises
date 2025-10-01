using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Core
{
    public abstract class DeviceBase : ISmartDevice
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        protected bool IsOn; 

        public DeviceBase(int id, string name)
        {
            Id = id;
            Name = name;
            IsOn = false;
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} {Id} turned ON");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} {Id} turned OFF");
        }

        public virtual string GetStatus()
        {
            return $"{Name} {Id} is {(IsOn ? "ON" : "OFF")}";
        }
    }
}
