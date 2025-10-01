using Exercise2.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Core
{
    public class DoorLockProxy : IDeviceProxy
    {
        private DoorLock door;
        private readonly string pin = "1234";

        public int Id => door.Id;
        public string Name => door.Name;

        public DoorLockProxy(DoorLock door)
        {
            this.door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void Authorize(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            if (key == pin)
                door.TurnOn();
            else
                Console.WriteLine("Unauthorized access to DoorLock");
        }

        public void TurnOn() => Authorize(pin);
        public void TurnOff() => door.TurnOff();
        public string GetStatus() => door.GetStatus();
    }
}
