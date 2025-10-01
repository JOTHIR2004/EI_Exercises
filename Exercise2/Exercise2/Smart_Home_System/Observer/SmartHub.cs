using Smart_Home_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Observer
{
    public class SmartHub
    {
        private static SmartHub instance;
        private List<ISmartDevice> devices = new List<ISmartDevice>();

        private SmartHub() { }

        public static SmartHub Instance => instance ??= new SmartHub();

        public IReadOnlyList<ISmartDevice> Devices => devices.AsReadOnly();

        public void RegisterDevice(ISmartDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Device registered: {device.Name} {device.Id}");
        }

        public void ShowStatus()
        {
            foreach (var d in devices)
                Console.WriteLine(d.GetStatus());
        }
    }
}
