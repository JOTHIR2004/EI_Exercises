using Exercise2.Core;
using Exercise2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Devices
{
    public class DoorLock : DeviceBase, IDeviceSubject
    {
        private List<IDeviceObserver> observers = new List<IDeviceObserver>();

        public DoorLock(int id) : base(id, "DoorLock") { }

        public override void TurnOn()
        {
            Console.WriteLine("Door unlocked");
            base.TurnOn();
            NotifyObservers("Door unlocked");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Door locked");
            base.TurnOff();
            NotifyObservers("Door locked");
        }

        public void RegisterObserver(IDeviceObserver observer) => observers.Add(observer);
        public void RemoveObserver(IDeviceObserver observer) => observers.Remove(observer);
        public void NotifyObservers(string message)
        {
            foreach (var obs in observers)
                obs.Update(this, message);
        }
    }
}
