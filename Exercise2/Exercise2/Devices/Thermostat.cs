using Exercise2.Core;
using Exercise2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Devices
{
    public class Thermostat : DeviceBase, IDeviceSubject
    {
        private List<IDeviceObserver> observers = new List<IDeviceObserver>();
        public int Temperature { get; private set; }

        public Thermostat(int id) : base(id, "Thermostat") { }

        public void SetTemperature(int temp)
        {
            Temperature = temp;
            Console.WriteLine($"Thermostat {Id} temperature set to {Temperature}°C");
            NotifyObservers($"Temperature changed to {Temperature}°C");
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
